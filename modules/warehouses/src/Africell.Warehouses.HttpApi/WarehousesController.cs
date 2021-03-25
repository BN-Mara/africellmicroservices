using Africell.Warehouses.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Warehouses
{
    public abstract class WarehousesController : AbpController
    {
        protected WarehousesController()
        {
            LocalizationResource = typeof(WarehousesResource);
        }
    }
}
