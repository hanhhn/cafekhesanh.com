using AutoMapper;
using Coffee.DataAccess;
using Coffee.DataAccess.DbContext;
using Coffee.Libs.DataAccess.UnitOfWork;
using Coffee.Libs.Infrastructure;
using Coffee.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Coffee.Api.Configurations
{
	public static class DependencyInjection
	{
		public static void AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			var sqlConnectionString = configuration.GetValue<string>("DefaultConnectionString");

			services
				.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(sqlConnectionString))
				.AddScoped<IUnitOfWork, UnitOfWork<ApplicationDbContext>>();
		}

		public static void AddCustomAutoMapper(this IServiceCollection services)
		{
			Action<IMapperConfigurationExpression> InitMapper = config =>
			{
				config.AddAutoMapper();
			};

			var configuration = new MapperConfiguration(InitMapper);
			configuration.CompileMappings();
			IMapper mapper = configuration.CreateMapper();
			services.AddSingleton(mapper);
		}

		public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddCoreService();
			services.AddRepositories();
			services.AddServices();
			services.AddEmailServices(configuration);
		}
	}
}
