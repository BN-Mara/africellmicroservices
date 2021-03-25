using Africell.Images.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Images
{
    public abstract class ImagesController : AbpController
    {
        protected ImagesController()
        {
            LocalizationResource = typeof(ImagesResource);
        }
    }
}
