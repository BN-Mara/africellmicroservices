using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Africell.Product
{
    [DependsOn(
        typeof(ProductHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductConsoleApiClientModule : AbpModule
    {
        
    }
}
