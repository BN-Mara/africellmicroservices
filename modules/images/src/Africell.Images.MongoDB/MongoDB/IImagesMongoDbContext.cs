using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Images.MongoDB
{
    [ConnectionStringName(ImagesDbProperties.ConnectionStringName)]
    public interface IImagesMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
