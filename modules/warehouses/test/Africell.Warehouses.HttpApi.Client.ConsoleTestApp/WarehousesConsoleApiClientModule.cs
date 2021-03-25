using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class WarehousesConsoleApiClientModule : AbpModule
    {
        
    }
}
