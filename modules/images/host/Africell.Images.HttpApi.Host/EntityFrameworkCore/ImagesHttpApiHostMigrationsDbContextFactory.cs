using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Africell.Images.EntityFrameworkCore
{
    public class ImagesHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ImagesHttpApiHostMigrationsDbContext>
    {
        public ImagesHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ImagesHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Images"));

            return new ImagesHttpApiHostMigrationsDbContext(builder.Options);
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
