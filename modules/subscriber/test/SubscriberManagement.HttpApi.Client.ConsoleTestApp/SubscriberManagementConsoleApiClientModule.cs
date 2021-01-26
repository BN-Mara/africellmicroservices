using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SubscriberManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
