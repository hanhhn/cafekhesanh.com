using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Application
{
	public static class DependencyInjection
	{
		public static void AddCoreMapper(this IMapperConfigurationExpression configAction)
		{
			configAction.AddProfile<CfServiceProfile>();
		}

		public static void AddServices(this IServiceCollection services)
		{

		}
	}
}