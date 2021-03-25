using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Africell.Supervisor.MongoDB
{
    public class SupervisorMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public SupervisorMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}