using Microsoft.Extensions.DependencyInjection;
using System;

namespace Coffee.Libs.Infrastructure
{
	public static class HttpClientRegister
	{
		public static void AddHttpClientFor<T>(this IServiceCollection services, string name) where T : class
		{
			var defaultRequest = HttpClientExcention.GetClient(name);

			services.AddHttpClient(name, client =>
			{
				client.BaseAddress = new Uri(defaultRequest.BaseAddress);

				if (defaultRequest.Timeout > 0)
					client.Timeout = TimeSpan.FromMinutes(defaultRequest.Timeout);

				if (defaultRequest.RequestHeaders != null)
				{
					foreach (var header in defaultRequest.RequestHeaders)
					{
						client.DefaultRequestHeaders.Add(header.Key.Trim(), header.Value.Trim());
					}
				}

			}).AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>()
			.AddTypedClient(c => Refit.RestService.For<T>(c)).SetHandlerLifetime(TimeSpan.FromMinutes(5));
		}
	}
}
