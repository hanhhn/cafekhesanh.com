using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;
using System;

namespace Coffee.Libs.DataAccess.Identity.Entities
{
	public class AppUser : IdentityUser<int>, IEntityRoot
	{
		public DateTime LastPasswordChanged { get; set; }
	}
}