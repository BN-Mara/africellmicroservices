using Localization.Resources.AbpUi;
using Africell.Supervisor.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Africell.Supervisor
{
    [DependsOn(
        typeof(SupervisorApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class SupervisorHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SupervisorHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SupervisorResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
