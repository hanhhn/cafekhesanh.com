using Coffee.Core;
using Coffee.DataAccess;
using Coffee.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Api.Configurations
{
	public static class ServiceConfigure
	{
		public static void AddCustomServices(this IServiceCollection services)
		{
			services.AddCoreService();
			services.AddRepositories();
			services.AddServices();
		}
	}
}