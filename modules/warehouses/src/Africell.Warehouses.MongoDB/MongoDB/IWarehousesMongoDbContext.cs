using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Warehouses.MongoDB
{
    [ConnectionStringName(WarehousesDbProperties.ConnectionStringName)]
    public interface IWarehousesMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
