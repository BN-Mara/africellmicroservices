using Volo.Abp.Modularity;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyDomainSharedModule)
        )]
    public class SurveyDomainModule : AbpModule
    {

    }
}
