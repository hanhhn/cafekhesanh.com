using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Cf.Libs.Core.Infrastructure.Context
{
	public class IdentityContext : IIdentityContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityContext(HttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

		public string LoggedUser()
		{
			return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}