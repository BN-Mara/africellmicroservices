using Africell.Product.Localization;
using Volo.Abp.Application.Services;

namespace Africell.Product
{
    public abstract class ProductAppService : ApplicationService
    {
        protected ProductAppService():base()
        {
            LocalizationResource = typeof(ProductResource);
            ObjectMapperContext = typeof(ProductApplicationModule);
        }
    }
}
