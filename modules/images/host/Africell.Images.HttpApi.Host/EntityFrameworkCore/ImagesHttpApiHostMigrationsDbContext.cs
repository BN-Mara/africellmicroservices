using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Images.EntityFrameworkCore
{
    public class ImagesHttpApiHostMigrationsDbContext : AbpDbContext<ImagesHttpApiHostMigrationsDbContext>
    {
        public ImagesHttpApiHostMigrationsDbContext(DbContextOptions<ImagesHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureImages();
        }
    }
}
