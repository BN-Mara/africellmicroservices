using Africell.Supervisor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Supervisor
{
    public abstract class SupervisorController : AbpController
    {
        protected SupervisorController()
        {
            LocalizationResource = typeof(SupervisorResource);
        }
    }
}
