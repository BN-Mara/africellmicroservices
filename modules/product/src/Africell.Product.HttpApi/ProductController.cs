using Africell.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Product
{
    public abstract class ProductController : AbpController
    {
        protected ProductController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}
