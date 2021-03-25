using Volo.Abp.Reflection;

namespace Africell.Images.Permissions
{
    public class ImagesPermissions
    {
        public const string GroupName = "Images";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ImagesPermissions));
        }
    }
}