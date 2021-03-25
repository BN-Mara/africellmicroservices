using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(SupervisorApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class SupervisorHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Supervisor";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SupervisorApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
