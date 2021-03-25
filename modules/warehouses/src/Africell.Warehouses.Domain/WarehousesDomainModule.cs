using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(WarehousesDomainSharedModule)
    )]
    public class WarehousesDomainModule : AbpModule
    {

    }
}
