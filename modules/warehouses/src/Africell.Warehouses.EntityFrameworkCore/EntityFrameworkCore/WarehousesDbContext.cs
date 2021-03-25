using Africell.Warehouses.Warehouses;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Warehouses.EntityFrameworkCore
{
    [ConnectionStringName(WarehousesDbProperties.ConnectionStringName)]
    public class WarehousesDbContext : AbpDbContext<WarehousesDbContext>, IWarehousesDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Warehouse> Warehouses { get; set; }

        public WarehousesDbContext(DbContextOptions<WarehousesDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureWarehouses();
        }
    }
}