using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SubscriberManagement.EntityFrameworkCore
{
    public class SubscriberManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SubscriberManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}