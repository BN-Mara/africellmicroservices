using System.Data;
using Volo.Abp.Reflection;

namespace SubscriberManagement.Authorization
{
    public class SubscriberManagementPermissions
    {
        public const string GroupName = "SubscriberManagement";
        public const string SubGroupIndividual = "Individual";
        public const string SubGroupEtreprise = "Entreprise";
        public static class Individuals
        {
            public const string Default = GroupName + ".Individual";
         
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default +  ".Create";
            public const string Verify = Default +  ".Verify";
            public const string ViewAll = Default + ".View.All";


        }
        public static class Entreprises
        {
            public const string Default = GroupName + ".Entreprise";

            public const string Delete = Default  + ".Delete";
            public const string Update = Default  + ".Update";
            public const string Create= Default   + ".Create";
            public const string Verify = Default  + ".Verify";
            public const string ViewAll = Default + ".View.All";

          

        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SubscriberManagementPermissions));
        }
    }
}