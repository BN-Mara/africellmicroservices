using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class WarehousesHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Warehouses";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(WarehousesApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
