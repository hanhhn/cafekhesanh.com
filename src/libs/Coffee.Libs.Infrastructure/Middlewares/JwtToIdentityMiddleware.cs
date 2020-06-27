using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Coffee.Libs.Infrastructure
{
	public class JwtToIdentityMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<JwtToIdentityMiddleware> _logger;

		public JwtToIdentityMiddleware(RequestDelegate next,
			ILogger<JwtToIdentityMiddleware> logger)
		{
			_next = next;
			_logger = logger;
		}

		public async Task Invoke(HttpContext context)
		{
			var authorization = context.Request.Headers["Authorization"].ToString();
			if (!string.IsNullOrEmpty(authorization))
			{
				var token = authorization.Split(" ")[1];
				var jwtToken = new JwtSecurityToken(token);
				if (jwtToken != null)
				{
					JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
					var principal = new ClaimsPrincipal(new ClaimsIdentity(jwtToken.Claims));
					context.User = principal;
				}
			}

			await _next(context);
		}
	}
}
