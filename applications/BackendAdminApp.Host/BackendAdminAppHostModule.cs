using System;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

using StackExchange.Redis;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Volo.Abp;
using Volo.Abp.AspNetCore.Authentication.OAuth;
using Volo.Abp.AspNetCore.Mvc.Client;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.Autofac;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Http.Client.IdentityModel.Web;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Web;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.Web;
using Volo.Abp.UI.Navigation;
using Volo.Blogging;
using SubscriberManagement;
using Africell.Erp.Shared;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;

namespace BackendAdminApp.Host
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcClientModule),
        typeof(AbpAspNetCoreAuthenticationOAuthModule),
        typeof(AbpHttpClientIdentityModelWebModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpIdentityWebModule),
      //  typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpTenantManagementWebModule),
        typeof(BloggingApplicationContractsModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(SubscriberManagementHttpApiClientModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
        )]
        public class BackendAdminAppHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                options.Languages.Add(new LanguageInfo("fr", "fr", "French"));

            });

            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = AfricellErpConsts.IsMultiTenancyEnabled;
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BackendAdminAppMenuContributor(configuration));
            });
            context.Services.AddSameSiteCookiePolicy();
            context.Services.AddAuthentication(options =>
                {
                    options.DefaultScheme = "Cookies";
                    options.DefaultChallengeScheme = "oidc";
                })
                .AddCookie("Cookies", options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromDays(365);
                    //options.Cookie.SameSite = SameSiteMode.None;
                    //options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    //options.Cookie.IsEssential = true;
                })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.ClientId = configuration["AuthServer:ClientId"];
                    options.ClientSecret = configuration["AuthServer:ClientSecret"];
                    options.RequireHttpsMetadata = false;
                    options.UsePkce = false;
                    options.ResponseType = OpenIdConnectResponseType.CodeIdToken;
                    options.SaveTokens = true;
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.Scope.Add("role");
                    options.Scope.Add("email");
                    options.Scope.Add("phone");
                    options.Scope.Add("BackendAdminAppGateway");
                    options.Scope.Add("IdentityService");
                    options.Scope.Add("SubscriberService");
                    options.Scope.Add("SurveyService");
                   // options.Scope.Add("TenantManagementService");
                    options.ClaimActions.MapAbpClaimTypes();
                });

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Backend Admin Application API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                });

            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration["Redis:Configuration"];
            });

            var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
            context.Services.AddDataProtection()
                .PersistKeysToStackExchangeRedis(redis, "AfricellERP-DataProtection-Keys");
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if (!env.IsDevelopment())
            {
                app.UseErrorPage();
            }
            app.UseCorrelationId();
            app.UseVirtualFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            if (AfricellErpConsts.IsMultiTenancyEnabled)
            {
                app.UseMultiTenancy();
            }
            app.UseAuthorization();
            app.UseAbpRequestLocalization();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend Admin Application API");
            });
            app.UseConfiguredEndpoints();
            //UseMvcWithDefaultRouteAndArea();

        }
    }
}
