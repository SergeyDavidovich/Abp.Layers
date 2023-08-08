using Abp.Layers.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Layers.Permissions;

public class LayersPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LayersPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LayersPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LayersResource>(name);
    }
}
