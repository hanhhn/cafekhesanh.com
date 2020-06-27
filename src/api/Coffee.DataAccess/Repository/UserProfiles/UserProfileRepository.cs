using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Account;

namespace Coffee.DataAccess.Repository.UserProfiles
{
	public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
	{
		public UserProfileRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
