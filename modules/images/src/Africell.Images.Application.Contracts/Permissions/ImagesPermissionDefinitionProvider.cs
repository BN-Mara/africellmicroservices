using Africell.Images.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Africell.Images.Permissions
{
    public class ImagesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ImagesPermissions.GroupName, L("Permission:Images"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ImagesResource>(name);
        }
    }
}