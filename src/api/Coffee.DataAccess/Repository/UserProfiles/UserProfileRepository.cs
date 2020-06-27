using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
	{
		public UserProfileRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
