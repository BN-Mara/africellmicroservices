using SubscriberManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SubscriberManagement
{
    public abstract class SubscriberManagementController : AbpController
    {
        protected SubscriberManagementController()
        {
            LocalizationResource = typeof(SubscriberManagementResource);
        }
    }
}
