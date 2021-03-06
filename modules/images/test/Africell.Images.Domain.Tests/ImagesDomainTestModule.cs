using Africell.Images.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Africell.Images
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ImagesEntityFrameworkCoreTestModule)
        )]
    public class ImagesDomainTestModule : AbpModule
    {
        
    }
}
