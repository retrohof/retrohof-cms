using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using DefaultResource = Retrohof.Localization.DefaultResource;

namespace Retrohof.Permissions;

public class RetrohofPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RetrohofPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RetrohofPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DefaultResource>(name);
    }
}
