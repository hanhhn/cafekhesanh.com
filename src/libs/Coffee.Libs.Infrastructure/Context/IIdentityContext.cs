namespace Coffee.Libs.Infrastructure
{
	public interface IIdentityContext
	{
		string GetUID();
		string GetUserIdentity();
		string GetUserName();
		string GetSiteId();
	}
}
