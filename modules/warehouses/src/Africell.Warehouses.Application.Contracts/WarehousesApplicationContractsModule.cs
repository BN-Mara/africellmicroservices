using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class WarehousesApplicationContractsModule : AbpModule
    {

    }
}
