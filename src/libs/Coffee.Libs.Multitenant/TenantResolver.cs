using Microsoft.AspNetCore.Http;
using SaasKit.Multitenancy;
using Coffee.Libs.Core.Exeptions;
using System.Threading.Tasks;

namespace Coffee.Libs.Multitenant
{
	public class TenantResolver : ITenantResolver<Tenant>
	{
		private readonly ITanentProvider _tanentProvider;

		public TenantResolver(ITanentProvider tanentProvider)
		{
			_tanentProvider = tanentProvider;
		}

		public Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
		{
			var Id = context.Request.Headers["Site"].ToString();
			var tenant = _tanentProvider.GetTenant(Id);

			if (tenant == null)
				throw new SnpException("Cannot resolve tenent context!");

			return Task.FromResult(new TenantContext<Tenant>(tenant));
		}
	}
}
