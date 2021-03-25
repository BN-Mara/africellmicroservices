using Localization.Resources.AbpUi;
using Africell.Warehouses.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class WarehousesHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(WarehousesHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<WarehousesResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
