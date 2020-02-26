using Cf.Libs.Core.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;

namespace Cf.Libs.DataAccess.Entities.Account
{
    public class UserLogin : IdentityUserLogin<string>, IEntityRoot
    {
    }
}
