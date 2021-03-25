using Localization.Resources.AbpUi;
using Africell.Images.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Africell.Images
{
    [DependsOn(
        typeof(ImagesApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ImagesHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ImagesHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ImagesResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
