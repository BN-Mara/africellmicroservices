using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Africell.Images
{
    [DependsOn(
        typeof(ImagesDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ImagesApplicationContractsModule : AbpModule
    {

    }
}
