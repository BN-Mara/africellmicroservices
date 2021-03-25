using Africell.Warehouses.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Africell.Warehouses
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(WarehousesEntityFrameworkCoreTestModule)
        )]
    public class WarehousesDomainTestModule : AbpModule
    {
        
    }
}
