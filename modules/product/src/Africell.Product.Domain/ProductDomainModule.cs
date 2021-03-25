using Volo.Abp.Autofac;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Africell.Product
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ProductDomainSharedModule),
        typeof(AbpAutofacModule)
    )]
    public class ProductDomainModule : AbpModule
    {

    }
}
