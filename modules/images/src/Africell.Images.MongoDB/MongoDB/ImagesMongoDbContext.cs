using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Images.MongoDB
{
    [ConnectionStringName(ImagesDbProperties.ConnectionStringName)]
    public class ImagesMongoDbContext : AbpMongoDbContext, IImagesMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureImages();
        }
    }
}