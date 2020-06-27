using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;

namespace Coffee.Libs.DataAccess.Identity.Entities
{
	public class AppRoleClaim : IdentityRoleClaim<int>, IEntityRoot
	{
	}
}
