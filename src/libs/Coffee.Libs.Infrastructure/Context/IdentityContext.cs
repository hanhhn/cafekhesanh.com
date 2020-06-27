using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;

namespace Coffee.Libs.Infrastructure
{
	public class IdentityContext : IIdentityContext
	{
		private readonly IHttpContextAccessor _context;

		public IdentityContext(IHttpContextAccessor context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context)); ;
		}

		public string GetUID()
		{
			return _context.HttpContext.User.FindFirstValue("uid");
		}

		public string GetUserIdentity()
		{
			return _context.HttpContext.User.FindFirstValue("sub");
		}

		public string GetUserName()
		{
			return _context.HttpContext.User.FindFirstValue("email");
		}

		public string GetSiteId()
		{
			return _context.HttpContext.Request.Headers["site"];
		}
	}
}