using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SurveyApplicationContractsModule : AbpModule
    {

    }
}
