using Africell.Erp.Survey.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Africell.Erp.Survey.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SurveyPageModel : AbpPageModel
    {
        protected SurveyPageModel()
        {
            LocalizationResourceType = typeof(SurveyResource);
            ObjectMapperContext = typeof(SurveyWebModule);
        }
    }
}