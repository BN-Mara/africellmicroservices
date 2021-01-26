using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Authorization;
using Volo.Abp.Localization;
using SubscriberManagement.Localization;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SubscriberManagementApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
           
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<SubscriberManagementApplicationContractsModule>("SubscriberManagement");
            });
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SubscriberManagementResource>()
                    .AddVirtualJson("/SubscriberManagement/Localization/ApplicationContracts");
            });
        }
    }
}
