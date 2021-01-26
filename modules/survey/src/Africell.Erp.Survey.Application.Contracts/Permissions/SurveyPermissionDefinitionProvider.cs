using Africell.Erp.Survey.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Africell.Erp.Survey.Permissions
{
    public class SurveyPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SurveyPermissions.GroupName, L("Permission:Survey"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SurveyResource>(name);
        }
    }
}