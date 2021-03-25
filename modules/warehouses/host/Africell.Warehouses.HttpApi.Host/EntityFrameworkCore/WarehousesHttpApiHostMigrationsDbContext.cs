using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Warehouses.EntityFrameworkCore
{
    public class WarehousesHttpApiHostMigrationsDbContext : AbpDbContext<WarehousesHttpApiHostMigrationsDbContext>
    {
        public WarehousesHttpApiHostMigrationsDbContext(DbContextOptions<WarehousesHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureWarehouses();
        }
    }
}
