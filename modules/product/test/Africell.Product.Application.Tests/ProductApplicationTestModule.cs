using Volo.Abp.Modularity;

namespace Africell.Product
{
    [DependsOn(
        typeof(ProductApplicationModule),
        typeof(ProductDomainTestModule)
        )]
    public class ProductApplicationTestModule : AbpModule
    {

    }
}
