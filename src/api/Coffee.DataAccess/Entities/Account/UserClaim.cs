using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;

namespace Coffee.DataAccess.Entities.Account
{
	public class UserClaim : IdentityUserClaim<string>, IEntityRoot
	{
	}
}
