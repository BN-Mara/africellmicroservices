using Volo.Abp.Reflection;

namespace Africell.Supervisor.Permissions
{
    public class SupervisorPermissions
    {
        public const string GroupName = "Supervisor";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SupervisorPermissions));
        }
    }
}