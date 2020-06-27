using Microsoft.AspNetCore.Identity;
using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.Libs.DataAccess.Identity.Entities
{
	public class AppUserToken : IdentityUserToken<int>, IEntityRoot
	{
	}
}
