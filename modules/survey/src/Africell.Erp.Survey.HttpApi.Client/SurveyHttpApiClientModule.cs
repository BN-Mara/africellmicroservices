using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class SurveyHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Survey";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SurveyApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
