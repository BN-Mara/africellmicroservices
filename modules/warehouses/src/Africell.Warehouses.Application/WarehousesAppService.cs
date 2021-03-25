using Africell.Warehouses.Localization;
using Volo.Abp.Application.Services;

namespace Africell.Warehouses
{
    public abstract class WarehousesAppService : ApplicationService
    {
        protected WarehousesAppService()
        {
            LocalizationResource = typeof(WarehousesResource);
            ObjectMapperContext = typeof(WarehousesApplicationModule);
        }
    }
}
