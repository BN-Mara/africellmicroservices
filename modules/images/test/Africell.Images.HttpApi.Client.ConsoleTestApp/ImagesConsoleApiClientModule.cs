using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Africell.Images
{
    [DependsOn(
        typeof(ImagesHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ImagesConsoleApiClientModule : AbpModule
    {
        
    }
}
