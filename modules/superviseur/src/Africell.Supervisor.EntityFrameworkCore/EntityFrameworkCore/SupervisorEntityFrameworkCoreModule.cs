using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Africell.Supervisor.EntityFrameworkCore
{
    [DependsOn(
        typeof(SupervisorDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class SupervisorEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SupervisorDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}