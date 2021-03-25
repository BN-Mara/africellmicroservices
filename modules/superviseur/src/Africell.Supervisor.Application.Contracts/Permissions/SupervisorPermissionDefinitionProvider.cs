using Africell.Supervisor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Africell.Supervisor.Permissions
{
    public class SupervisorPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SupervisorPermissions.GroupName, L("Permission:Supervisor"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SupervisorResource>(name);
        }
    }
}