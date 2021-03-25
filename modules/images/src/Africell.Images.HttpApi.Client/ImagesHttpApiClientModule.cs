using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Africell.Images
{
    [DependsOn(
        typeof(ImagesApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ImagesHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Images";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ImagesApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
