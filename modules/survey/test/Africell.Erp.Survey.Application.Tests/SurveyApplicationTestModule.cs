using Volo.Abp.Modularity;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyApplicationModule),
        typeof(SurveyDomainTestModule)
        )]
    public class SurveyApplicationTestModule : AbpModule
    {

    }
}
