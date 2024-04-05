namespace Retrohof.Permissions;

public static class RetrohofPermissions
{
    public const string GroupName = "Retrohof";

	public static class GalleryImage
	{
		public const string Root = GroupName + ".GalleryImage";

		public const string Management = Root + ".Management";
		public const string Create = Root + ".Create";
		public const string Update = Root + ".Update";
		public const string Delete = Root + ".Delete";
	}
}
