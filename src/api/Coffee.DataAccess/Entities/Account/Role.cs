using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Coffee.DataAccess.Entities.Account
{
	public class Role : IdentityRole<string>, IEntityRoot
	{
		public virtual ICollection<UserRole> UserRoles { get; set; }
	}
}
