using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Warehouses.MongoDB
{
    [ConnectionStringName(WarehousesDbProperties.ConnectionStringName)]
    public class WarehousesMongoDbContext : AbpMongoDbContext, IWarehousesMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureWarehouses();
        }
    }
}