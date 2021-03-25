using Africell.Supervisor.Localization;
using Volo.Abp.Application.Services;

namespace Africell.Supervisor
{
    public abstract class SupervisorAppService : ApplicationService
    {
        protected SupervisorAppService()
        {
            LocalizationResource = typeof(SupervisorResource);
            ObjectMapperContext = typeof(SupervisorApplicationModule);
        }
    }
}
