using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Coffee.Libs.Core;
using Coffee.Libs.Core.Exeptions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Coffee.Libs.Multitenant
{
	public class TenantProvider : ITanentProvider
	{
		private IWebHostEnvironment _env;

		public TenantProvider(IWebHostEnvironment env)
		{
			_env = env;
			var tenant = SingletonList<List<Tenant>>.Instance;
			if (tenant == null || tenant.Count == 0)
			{
				var tenents = JsonConvert.DeserializeObject<Tenant[]>(File.ReadAllText("tenants.json"));
				SingletonList<Tenant>.Instance.AddRange(tenents);
			}
		}

		public Tenant GetTenant(string tenentId)
		{
			var tenant = SingletonList<Tenant>.Instance.FirstOrDefault(x => x.Id.ToUpper() == tenentId.ToUpper());

			if (_env.IsDevelopment() && tenant == null)
			{
				tenant = SingletonList<Tenant>.Instance.FirstOrDefault(x => x.Id.ToUpper() == "CTL");
			}

			if (tenant == null)
				throw new SnpException(string.Format("Unknow tenent '{0}'", tenentId));

			return tenant;
		}

		public Tenant[] GetTenants()
		{
			return SingletonList<Tenant>.Instance.ToArray();
		}
	}
}
