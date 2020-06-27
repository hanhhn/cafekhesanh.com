namespace Coffee.Libs.Multitenant
{
	public interface ITanentProvider
	{
		Tenant GetTenant(string id);
		Tenant[] GetTenants();
	}
}
