using Volo.Abp.Reflection;

namespace Africell.Product.Permissions
{
    public class ProductPermissions
    {
        public const string GroupName = "Product";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductPermissions));
        }
        public static class Products
        {
            public const string Default = GroupName + ".Products";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}