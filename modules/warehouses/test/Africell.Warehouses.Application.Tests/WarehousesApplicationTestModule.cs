using Volo.Abp.Modularity;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesApplicationModule),
        typeof(WarehousesDomainTestModule)
        )]
    public class WarehousesApplicationTestModule : AbpModule
    {

    }
}
