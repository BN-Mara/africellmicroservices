using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(SupervisorDomainSharedModule)
    )]
    public class SupervisorDomainModule : AbpModule
    {

    }
}
