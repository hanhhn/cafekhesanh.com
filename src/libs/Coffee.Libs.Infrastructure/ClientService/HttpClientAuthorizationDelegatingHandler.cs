using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Coffee.Libs.Infrastructure
{
	public class HttpClientAuthorizationDelegatingHandler : DelegatingHandler
	{
		private readonly IHttpContextAccessor _httpContextAccesor;

		public HttpClientAuthorizationDelegatingHandler(IHttpContextAccessor httpContextAccesor)
		{
			_httpContextAccesor = httpContextAccesor;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			request.Version = new System.Version(1, 0);
			var authorizationHeader = _httpContextAccesor.HttpContext.Request.Headers["Authorization"];
			var siteId = _httpContextAccesor.HttpContext.Request.Headers["Site"];

			if (!string.IsNullOrEmpty(authorizationHeader) && !request.Headers.Contains("Authorization"))
			{
				request.Headers.Add("Authorization", new List<string>() { authorizationHeader });
			}

			if (!string.IsNullOrEmpty(siteId) && !request.Headers.Contains("Site"))
			{
				request.Headers.Add("Site", new List<string>() { siteId });
			}

			//var token = await GetToken();
			//if (token != null)
			//{
			//	request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
			//}

			return await base.SendAsync(request, cancellationToken);
		}

		async Task<string> GetToken()
		{
			const string ACCESS_TOKEN = "access_token";
			return await _httpContextAccesor.HttpContext.GetTokenAsync(ACCESS_TOKEN);
		}
	}
}
