using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Timing;
using System;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementDomainModule),
        typeof(SubscriberManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class SubscriberManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpClockOptions>(options =>
            {
                options.Kind = DateTimeKind.Utc;
            });
            context.Services.AddAutoMapperObjectMapper<SubscriberManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<SubscriberManagementApplicationModule>(validate: true);
            });
        }
    }
}
