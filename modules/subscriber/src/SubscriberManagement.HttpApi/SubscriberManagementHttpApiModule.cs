using Localization.Resources.AbpUi;
using SubscriberManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class SubscriberManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SubscriberManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SubscriberManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
