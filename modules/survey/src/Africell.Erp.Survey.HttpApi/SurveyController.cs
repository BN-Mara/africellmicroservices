using Africell.Erp.Survey.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Erp.Survey
{
    public abstract class SurveyController : AbpController
    {
        protected SurveyController()
        {
            LocalizationResource = typeof(SurveyResource);
        }
    }
}
