using AutoMapper;
using Coffee.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Coffee.Api.Configurations
{
	public static class MapperConfigure
	{
		public static void AddMapper(this IServiceCollection services)
		{
			Action<IMapperConfigurationExpression> InitMapper = config =>
			{
				config.AddCoreMapper();
			};

			var configuration = new MapperConfiguration(InitMapper);
			configuration.CompileMappings();
			IMapper mapper = configuration.CreateMapper();
			services.AddSingleton(mapper);
		}
	}
}