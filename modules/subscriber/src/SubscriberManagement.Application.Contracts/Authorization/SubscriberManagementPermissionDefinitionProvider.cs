using SubscriberManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SubscriberManagement.Authorization
{
    public class SubscriberManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var moduleGroup = context.AddGroup(SubscriberManagementPermissions.GroupName, L("Permission:SubscriberManagement"));

            var individual= moduleGroup.AddPermission(SubscriberManagementPermissions.Individuals.Default, L("Permission:Individual"));
                individual.AddChild(SubscriberManagementPermissions.Individuals.Update, L("Permission:Edit"));
                individual.AddChild(SubscriberManagementPermissions.Individuals.Delete, L("Permission:Delete"));
                individual.AddChild(SubscriberManagementPermissions.Individuals.Create, L("Permission:Create"));
                individual.AddChild(SubscriberManagementPermissions.Individuals.ViewAll, L("Permission:ViewAll"));
            var entreprise = moduleGroup.AddPermission(SubscriberManagementPermissions.Entreprises.Default, L("Permission:Entreprise"));
                entreprise.AddChild(SubscriberManagementPermissions.Entreprises.Update, L("Permission:Edit"));
                entreprise.AddChild(SubscriberManagementPermissions.Entreprises.Delete, L("Permission:Delete"));
                entreprise.AddChild(SubscriberManagementPermissions.Entreprises.Create, L("Permission:Create"));
                entreprise.AddChild(SubscriberManagementPermissions.Entreprises.ViewAll,L("Permission:ViewAll"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SubscriberManagementResource>(name);
        }
    }
}