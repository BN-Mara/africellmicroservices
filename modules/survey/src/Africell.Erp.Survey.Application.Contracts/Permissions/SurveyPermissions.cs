using Volo.Abp.Reflection;

namespace Africell.Erp.Survey.Permissions
{
    public class SurveyPermissions
    {
        public const string GroupName = "Survey";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SurveyPermissions));
        }
    }
}