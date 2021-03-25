using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Africell.Images.MongoDB
{
    public class ImagesMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ImagesMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}