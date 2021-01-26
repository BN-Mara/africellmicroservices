using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class SubscriberManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "SubscriberManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SubscriberManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
