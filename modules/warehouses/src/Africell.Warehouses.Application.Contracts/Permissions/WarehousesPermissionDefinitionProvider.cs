using Africell.Warehouses.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Africell.Warehouses.Permissions
{
    public class WarehousesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WarehousesPermissions.GroupName, L("Permission:Warehouses"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WarehousesResource>(name);
        }
    }
}