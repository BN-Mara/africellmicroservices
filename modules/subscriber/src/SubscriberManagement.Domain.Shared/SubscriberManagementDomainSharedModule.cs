using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using SubscriberManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class SubscriberManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<SubscriberManagementDomainSharedModule>("SubscriberManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<SubscriberManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/SubscriberManagement");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("SubscriberManagement", typeof(SubscriberManagementResource));
            });
        }
    }
}
