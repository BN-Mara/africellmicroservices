using Africell.Images.Images;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Images.EntityFrameworkCore
{
    [ConnectionStringName(ImagesDbProperties.ConnectionStringName)]
    public class ImagesDbContext : AbpDbContext<ImagesDbContext>, IImagesDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Image> Images { get; set; }

        public ImagesDbContext(DbContextOptions<ImagesDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureImages();
        }
    }
}