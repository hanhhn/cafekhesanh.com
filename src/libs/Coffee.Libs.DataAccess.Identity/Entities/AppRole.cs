using Microsoft.AspNetCore.Identity;
using Coffee.Libs.DataAccess.EntityRoot;
using System.Collections.Generic;

namespace Coffee.Libs.DataAccess.Identity.Entities
{
	public class AppRole : IdentityRole<int>, IEntityRoot
	{
		public virtual ICollection<AppUserRole> UserRoles { get; set; }
	}
}
