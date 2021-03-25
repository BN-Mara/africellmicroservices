using Africell.Product.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Africell.Product.Permissions
{
    public class ProductPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductPermissions.GroupName, L("Permission:Product"));
            var productPermission = myGroup.AddPermission(
                ProductPermissions.Products.Default, L("Permission:Products")
                );
            productPermission.AddChild(ProductPermissions.Products.Create, L("Permission:Products.Create"));
            productPermission.AddChild(ProductPermissions.Products.Edit, L("Permission:Products.Edit"));
            productPermission.AddChild(ProductPermissions.Products.Delete, L("Permission:Products.Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductResource>(name);
        }
    }
}