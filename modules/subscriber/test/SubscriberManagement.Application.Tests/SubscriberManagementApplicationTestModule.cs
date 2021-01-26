using Volo.Abp.Modularity;

namespace SubscriberManagement
{
    [DependsOn(
        typeof(SubscriberManagementApplicationModule),
        typeof(SubscriberManagementDomainTestModule)
        )]
    public class SubscriberManagementApplicationTestModule : AbpModule
    {

    }
}
