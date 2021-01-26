using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SubscriberManagement.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SubscriberManagementMigrationsDbContextFactory : IDesignTimeDbContextFactory<SubscriberManagementMigrationsDbContext>
    {
        public SubscriberManagementMigrationsDbContext CreateDbContext(string[] args)
        {
            //SubscriberManagementEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SubscriberManagementMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString(SubscriberManagementDbProperties.ConnectionStringName));

            return new SubscriberManagementMigrationsDbContext(builder.Options);
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
