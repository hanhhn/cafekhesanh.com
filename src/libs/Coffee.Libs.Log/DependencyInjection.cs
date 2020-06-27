using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Libs.Log
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddLogManager(this IServiceCollection services)
		{
			services.AddSingleton<ILogManger, LogManager>();
			return services;
		}
	}
}
