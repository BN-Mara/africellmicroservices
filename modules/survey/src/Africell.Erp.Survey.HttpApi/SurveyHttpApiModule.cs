using Localization.Resources.AbpUi;
using Africell.Erp.Survey.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Africell.Erp.Survey
{
    [DependsOn(
        typeof(SurveyApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class SurveyHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SurveyHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SurveyResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
