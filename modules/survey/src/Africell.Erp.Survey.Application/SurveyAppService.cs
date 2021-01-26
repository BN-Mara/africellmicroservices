using Africell.Erp.Survey.Localization;
using Volo.Abp.Application.Services;

namespace Africell.Erp.Survey
{
    public abstract class SurveyAppService : ApplicationService
    {
        protected SurveyAppService()
        {
            LocalizationResource = typeof(SurveyResource);
            ObjectMapperContext = typeof(SurveyApplicationModule);
        }
    }
}
