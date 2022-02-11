namespace Acme.BookStore.Permissions;

public static class BookStorePermissions
{
    public const string GroupName = "BookStore";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Books
    {
        public const string Default = $"{GroupName}.Books";
        public const string Create = $"{GroupName}.Create";
        public const string Edit = $"{GroupName}.Edit";
        public const string Delete = $"{GroupName}.Delete";
    }
}
