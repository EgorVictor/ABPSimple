using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));

        PermissionDefinition bookPermission = myGroup.AddPermission(BookStorePermissions.Books.Default, L("Permission:Books"));
        bookPermission.AddChild(BookStorePermissions.Books.Create, L("Permission:Create"));
        bookPermission.AddChild(BookStorePermissions.Books.Edit, L("Permission:Edit"));
        bookPermission.AddChild(BookStorePermissions.Books.Delete, L("Permission:Delete"));

        PermissionDefinition authorPermission = myGroup.AddPermission(BookStorePermissions.Authors.Default, L("Permission:Author"));
        authorPermission.AddChild(BookStorePermissions.Authors.Create, L("Permission:Create"));
        authorPermission.AddChild(BookStorePermissions.Authors.Edit, L("Permission:Edit"));
        authorPermission.AddChild(BookStorePermissions.Authors.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
