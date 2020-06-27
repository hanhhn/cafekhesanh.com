using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Libs.Multitenant
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddCustomMultitenancy(this IServiceCollection services)
		{
			services.AddSingleton<ITanentProvider, TenantProvider>();

			services.AddMultitenancy<Tenant, TenantResolver>();

			return services;
		}

		public static IApplicationBuilder UseCustomMultitenancy(this IApplicationBuilder app)
		{
			app.UseMultitenancy<Tenant>();
			return app;
		}
	}
}
