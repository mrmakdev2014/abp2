using abpdemo1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpdemo1.Permissions
{
    public class abpdemo1PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abpdemo1Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(abpdemo1Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abpdemo1Resource>(name);
        }
    }
}
