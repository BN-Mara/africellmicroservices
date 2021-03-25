using Africell.Images.Localization;
using Volo.Abp.Application.Services;

namespace Africell.Images
{
    public abstract class ImagesAppService : ApplicationService
    {
        protected ImagesAppService()
        {
            LocalizationResource = typeof(ImagesResource);
            ObjectMapperContext = typeof(ImagesApplicationModule);
        }
    }
}
