using SubscriberManagement.Localization;
using Volo.Abp.Application.Services;

namespace SubscriberManagement
{
    public abstract class SubscriberManagementAppService : ApplicationService
    {
        protected SubscriberManagementAppService()
        {
            LocalizationResource = typeof(SubscriberManagementResource);
            ObjectMapperContext = typeof(SubscriberManagementApplicationModule);
        }
    }
}
