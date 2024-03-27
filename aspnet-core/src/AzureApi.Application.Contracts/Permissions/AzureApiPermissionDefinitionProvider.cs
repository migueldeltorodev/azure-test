using AzureApi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AzureApi.Permissions;

public class AzureApiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AzureApiPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AzureApiPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AzureApiResource>(name);
    }
}
