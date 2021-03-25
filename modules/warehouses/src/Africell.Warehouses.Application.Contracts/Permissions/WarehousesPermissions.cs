using Volo.Abp.Reflection;

namespace Africell.Warehouses.Permissions
{
    public class WarehousesPermissions
    {
        public const string GroupName = "Warehouses";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(WarehousesPermissions));
        }
    }
}