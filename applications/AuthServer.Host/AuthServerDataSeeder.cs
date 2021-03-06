using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.IdentityServer.ApiScopes;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.IdentityResources;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;

namespace AuthServer.Host
{
    public class AuthServerDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IApiScopeRepository _apiScopeRepository;
        private readonly IApiResourceRepository _apiResourceRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IIdentityResourceDataSeeder _identityResourceDataSeeder;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IPermissionDataSeeder _permissionDataSeeder;

        public AuthServerDataSeeder(
            IClientRepository clientRepository,
            IApiResourceRepository apiResourceRepository,
            IApiScopeRepository apiScopeRepository,
            IIdentityResourceDataSeeder identityResourceDataSeeder,
            IGuidGenerator guidGenerator,
            IPermissionDataSeeder permissionDataSeeder)
        {
            _clientRepository = clientRepository;
            _apiResourceRepository = apiResourceRepository;
            _apiScopeRepository = apiScopeRepository;
            _identityResourceDataSeeder = identityResourceDataSeeder;
            _guidGenerator = guidGenerator;
            _permissionDataSeeder = permissionDataSeeder;
        }

        [UnitOfWork]
        public virtual async Task SeedAsync(DataSeedContext context)
        {
            await _identityResourceDataSeeder.CreateStandardResourcesAsync();
            await CreateApiResourcesAsync();
            await CreateApiScopesAsync();
            await CreateClientsAsync();
        }
        private async Task<ApiScope> CreateApiScopeAsync(string name)
        {
            var apiScope = await _apiScopeRepository.GetByNameAsync(name);
            if (apiScope == null)
            {
                apiScope = await _apiScopeRepository.InsertAsync(
                    new ApiScope(
                        _guidGenerator.Create(),
                        name,
                        name + " API"
                    ),
                    autoSave: true
                );
            }

            return apiScope;
        }

        private async Task CreateApiResourcesAsync()
        {
            var commonApiUserClaims = new[]
            {
                "email",
                "email_verified",
                "name",
                "phone_number",
                "phone_number_verified",
                "role"
            };

            await CreateApiResourceAsync("IdentityService", commonApiUserClaims);
            await CreateApiResourceAsync("SurveyService", commonApiUserClaims);
            await CreateApiResourceAsync("SubscriberService", commonApiUserClaims);
            await CreateApiResourceAsync("InternalGateway", commonApiUserClaims);
            await CreateApiResourceAsync("BackendAdminAppGateway", commonApiUserClaims);
            await CreateApiResourceAsync("PublicWebSiteGateway", commonApiUserClaims);
            await CreateApiResourceAsync("MobileGateway", commonApiUserClaims);
        }
        private async Task CreateApiScopesAsync()
        {
            await CreateApiScopeAsync("IdentityService");
            await CreateApiScopeAsync("SurveyService");
            await CreateApiScopeAsync("SubscriberService");
            await CreateApiScopeAsync("InternalGateway");
            await CreateApiScopeAsync("BackendAdminAppGateway");
            await CreateApiScopeAsync("PublicWebSiteGateway");
            await CreateApiScopeAsync("MobileGateway");
        }

        private async Task<ApiResource> CreateApiResourceAsync(string name, IEnumerable<string> claims)
        {
            var apiResource = await _apiResourceRepository.FindByNameAsync(name);
            if (apiResource == null)
            {
                apiResource = await _apiResourceRepository.InsertAsync(
                    new ApiResource(
                        _guidGenerator.Create(),
                        name,
                        name + " API"
                    ),
                    autoSave: true
                );
            }

            foreach (var claim in claims)
            {
                if (apiResource.FindClaim(claim) == null)
                {
                    apiResource.AddUserClaim(claim);
                }
            }
            // apiResource.AddScope(name);
            return await _apiResourceRepository.UpdateAsync(apiResource);
        }

        private async Task CreateClientsAsync()
        {
            const string commonSecret = "E5Xd4yMqjP5kjWFKrYgySBju6JVfCzMyFp7n2QmMrME=";

            var commonScopes = new[]
            {
                "email",
                "openid",
                "profile",
                "role",
                "phone",
                "address",

            };

            await CreateClientAsync(
                "kaios-app-client",
                new[] { "IdentityService", "MobileGateway", "SubscriberService", "offline_access" },
                new[] { "client_credentials", "password" },
                commonSecret,
                permissions: new[] { IdentityPermissions.Users.Default, "SubscriberManagement.Individual" }
            );

            await CreateClientAsync(
                "backend-admin-app-client",
                commonScopes.Union(new[] { "BackendAdminAppGateway", "IdentityService", "SubscriberService", "SurveyService" }),
                new[] { "hybrid", "client_credentials" },
                //{ "client_credentials",  "authorization_code" },
                commonSecret,
                permissions: new[] { IdentityPermissions.Users.Default, "SubscriberManagement.Individual", "SubscriberManagement.Entreprise" },
                redirectUri: "http://localhost:64600/signin-oidc",
                postLogoutRedirectUri: "http://localhost:64600/signout-callback-oidc"
            );

            await CreateClientAsync(
                "susbcriber-website-client",
                commonScopes.Union(new[] { "PublicWebSiteGateway", "SubscriberService" }),
                new[] { "hybrid" },
                commonSecret,
                redirectUri: "http://localhost:53435/signin-oidc",
                postLogoutRedirectUri: "http://localhost:53435/signout-callback-oidc"
            );

            //await CreateClientAsync(
            //    "blogging-service-client",
            //    new[] { "InternalGateway", "IdentityService" },
            //    new[] { "client_credentials" },
            //    commonSecret,
            //    permissions: new[] { IdentityPermissions.UserLookup.Default }
            //);
        }

        private async Task<Client> CreateClientAsync(
            string name,
            IEnumerable<string> scopes,
            IEnumerable<string> grantTypes,
            string secret,
            string redirectUri = null,
            string postLogoutRedirectUri = null,
            IEnumerable<string> permissions = null)
        {
            var client = await _clientRepository.FindByClientIdAsync(name);
            if (client == null)
            {
                client = await _clientRepository.InsertAsync(
                    new Client(
                        _guidGenerator.Create(),
                        name
                    )
                    {
                        ClientName = name,
                        ProtocolType = "oidc",
                        Description = name,
                        AlwaysIncludeUserClaimsInIdToken = true,
                        AllowOfflineAccess = true,
                        AbsoluteRefreshTokenLifetime = 31536000, //365 days
                        AccessTokenLifetime = 31536000, //365 days
                        AuthorizationCodeLifetime = 300,
                        IdentityTokenLifetime = 300,
                        RequireConsent = false,
                        RequirePkce = false

                    },
                    autoSave: true
                ); ;
            }

            foreach (var scope in scopes)
            {
                if (client.FindScope(scope) == null)
                {
                    client.AddScope(scope);
                }
            }

            foreach (var grantType in grantTypes)
            {
                if (client.FindGrantType(grantType) == null)
                {
                    client.AddGrantType(grantType);
                }
            }

            if (client.FindSecret(secret) == null)
            {
                client.AddSecret(secret);
            }

            if (redirectUri != null)
            {
                if (client.FindRedirectUri(redirectUri) == null)
                {
                    client.AddRedirectUri(redirectUri);
                }
                if (client.FrontChannelLogoutUri == null)
                    client.FrontChannelLogoutUri = redirectUri;
            }

            if (postLogoutRedirectUri != null)
            {
                if (client.FindPostLogoutRedirectUri(postLogoutRedirectUri) == null)
                {
                    client.AddPostLogoutRedirectUri(postLogoutRedirectUri);
                }
            }
            if (permissions != null)
            {
                await _permissionDataSeeder.SeedAsync(
                    ClientPermissionValueProvider.ProviderName,
                    name,
                    permissions
                );
            }

            return await _clientRepository.UpdateAsync(client);
        }
    }
}
