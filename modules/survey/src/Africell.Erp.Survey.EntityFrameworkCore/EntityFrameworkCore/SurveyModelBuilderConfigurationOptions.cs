using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Erp.Survey.EntityFrameworkCore
{
    public class SurveyModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SurveyModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}