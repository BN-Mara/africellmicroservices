using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Africell.Erp.Survey.EntityFrameworkCore
{
    public class SurveyHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SurveyHttpApiHostMigrationsDbContext>
    {
        public SurveyHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SurveyHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Survey"));

            return new SurveyHttpApiHostMigrationsDbContext(builder.Options);
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
