using Volo.Abp.Modularity;

namespace Africell.Images
{
    [DependsOn(
        typeof(ImagesApplicationModule),
        typeof(ImagesDomainTestModule)
        )]
    public class ImagesApplicationTestModule : AbpModule
    {

    }
}
