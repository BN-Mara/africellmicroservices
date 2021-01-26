using SubscriberManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SubscriberManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(SubscriberManagementEntityFrameworkCoreTestModule)
        )]
    public class SubscriberManagementDomainTestModule : AbpModule
    {
        
    }
}
