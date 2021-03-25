using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Africell.Supervisor.EntityFrameworkCore
{
    public class SupervisorHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SupervisorHttpApiHostMigrationsDbContext>
    {
        public SupervisorHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SupervisorHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Supervisor"));

            return new SupervisorHttpApiHostMigrationsDbContext(builder.Options);
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
