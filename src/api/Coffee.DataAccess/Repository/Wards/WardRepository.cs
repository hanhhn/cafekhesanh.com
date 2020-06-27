using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class WardRepository : BaseRepository<Ward>, IWardRepository
	{
		public WardRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}