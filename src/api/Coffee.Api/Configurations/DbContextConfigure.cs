using Coffee.Core.Infrastructure.UnitOfWork;
using Coffee.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Api.Configurations
{
	public static class DbContextConfigure
	{
		public static void AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			var sqlConnectionString = configuration.GetValue<string>("DefaultConnectionString");

			services
				.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(sqlConnectionString))
				.AddScoped<IUnitOfWork, UnitOfWork<ApplicationDbContext>>();
		}
	}
}