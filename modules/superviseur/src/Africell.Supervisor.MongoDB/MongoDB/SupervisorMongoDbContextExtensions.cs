using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Africell.Supervisor.MongoDB
{
    public static class SupervisorMongoDbContextExtensions
    {
        public static void ConfigureSupervisor(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SupervisorMongoModelBuilderConfigurationOptions(
                SupervisorDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}