using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Supervisor.EntityFrameworkCore
{
    public class SupervisorModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SupervisorModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}