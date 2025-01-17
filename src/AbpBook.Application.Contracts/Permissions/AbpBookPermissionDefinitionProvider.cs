using AbpBook.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpBook.Permissions;

public class AbpBookPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpBookPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(AbpBookPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpBookPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpBookPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpBookPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpBookPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpBookResource>(name);
    }
}
