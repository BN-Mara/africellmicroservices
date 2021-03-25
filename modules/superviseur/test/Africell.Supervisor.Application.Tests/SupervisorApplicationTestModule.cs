using Volo.Abp.Modularity;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(SupervisorApplicationModule),
        typeof(SupervisorDomainTestModule)
        )]
    public class SupervisorApplicationTestModule : AbpModule
    {

    }
}
