using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Africell.Images.MongoDB
{
    public static class ImagesMongoDbContextExtensions
    {
        public static void ConfigureImages(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ImagesMongoModelBuilderConfigurationOptions(
                ImagesDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}