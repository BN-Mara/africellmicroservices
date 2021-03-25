using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Africell.Warehouses.MongoDB
{
    public class WarehousesMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public WarehousesMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}