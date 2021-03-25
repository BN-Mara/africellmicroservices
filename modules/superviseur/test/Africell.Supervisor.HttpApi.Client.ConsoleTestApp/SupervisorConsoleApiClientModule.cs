using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(SupervisorHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SupervisorConsoleApiClientModule : AbpModule
    {
        
    }
}
