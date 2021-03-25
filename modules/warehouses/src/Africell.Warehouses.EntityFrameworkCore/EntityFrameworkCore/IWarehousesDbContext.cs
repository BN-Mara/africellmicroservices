using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Warehouses.EntityFrameworkCore
{
    [ConnectionStringName(WarehousesDbProperties.ConnectionStringName)]
    public interface IWarehousesDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}