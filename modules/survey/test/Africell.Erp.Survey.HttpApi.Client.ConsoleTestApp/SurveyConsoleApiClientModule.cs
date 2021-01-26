using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SurveyConsoleApiClientModule : AbpModule
    {
        
    }
}
