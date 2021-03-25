using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(SupervisorDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SupervisorApplicationContractsModule : AbpModule
    {

    }
}
