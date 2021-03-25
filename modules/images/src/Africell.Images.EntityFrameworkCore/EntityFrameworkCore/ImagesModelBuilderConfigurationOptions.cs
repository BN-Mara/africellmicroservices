using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Images.EntityFrameworkCore
{
    public class ImagesModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ImagesModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}