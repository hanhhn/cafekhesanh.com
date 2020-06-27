using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Coffee.Libs.Multitenant
{
	public class MissingTenantMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly string _missingTanentUrl;

		public MissingTenantMiddleware(RequestDelegate next, string missingTanentUrl)
		{
			_next = next;
			_missingTanentUrl = missingTanentUrl;
		}

		public async Task Invoke(HttpContext httpContext, ITanentProvider provider)
		{
			if (provider.GetTenant("") == null)
			{
				httpContext.Response.Redirect(_missingTanentUrl);
				return;
			}

			await _next.Invoke(httpContext);
		}
	}
}
