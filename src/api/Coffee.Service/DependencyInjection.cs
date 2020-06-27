using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.Service
{
	public static class DependencyInjection
	{
		public static void AddServices(this IServiceCollection services)
		{

		}

		public static IServiceCollection AddEmailServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IEmailService, EmailService>(i =>
				new EmailService(
					configuration["EmailSender:Host"],
					configuration.GetValue<int>("EmailSender:Port"),
					configuration.GetValue<bool>("EmailSender:EnableSSL"),
					configuration["EmailSender:UserName"],
					configuration["EmailSender:Password"],
					configuration["EmailSender:From"]
				)
			);

			return services;
		}
	}
}