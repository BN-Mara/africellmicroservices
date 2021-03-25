using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Africell.Warehouses.EntityFrameworkCore
{
    public class WarehousesHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<WarehousesHttpApiHostMigrationsDbContext>
    {
        public WarehousesHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<WarehousesHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Warehouses"));

            return new WarehousesHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
