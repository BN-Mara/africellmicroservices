using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Warehouses.EntityFrameworkCore
{
    public class WarehousesModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public WarehousesModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}