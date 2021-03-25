using Africell.Supervisor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Africell.Supervisor
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(SupervisorEntityFrameworkCoreTestModule)
        )]
    public class SupervisorDomainTestModule : AbpModule
    {
        
    }
}
