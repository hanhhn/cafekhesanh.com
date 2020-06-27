using Microsoft.AspNetCore.Identity;
using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.Libs.DataAccess.Identity.Entities
{
	public class AppUserRole : IdentityUserRole<int>, IEntityRoot
	{
	}
}
