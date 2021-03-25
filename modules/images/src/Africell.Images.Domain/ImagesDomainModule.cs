using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Africell.Images
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ImagesDomainSharedModule)
    )]
    public class ImagesDomainModule : AbpModule
    {

    }
}
