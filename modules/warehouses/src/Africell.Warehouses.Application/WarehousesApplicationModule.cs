using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Africell.Warehouses
{
    [DependsOn(
        typeof(WarehousesDomainModule),
        typeof(WarehousesApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class WarehousesApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<WarehousesApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<WarehousesApplicationModule>(validate: true);
            });
        }
    }
}
