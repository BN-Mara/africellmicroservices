using Volo.Abp.Modularity;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementDomainSharedModule)
        )]
    public class SubscriberManagementDomainModule : AbpModule
    {

    }
}
