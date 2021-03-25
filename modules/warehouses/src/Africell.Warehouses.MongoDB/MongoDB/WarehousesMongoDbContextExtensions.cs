using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Africell.Warehouses.MongoDB
{
    public static class WarehousesMongoDbContextExtensions
    {
        public static void ConfigureWarehouses(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WarehousesMongoModelBuilderConfigurationOptions(
                WarehousesDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}