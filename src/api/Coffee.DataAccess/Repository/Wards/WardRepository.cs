using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Common;

namespace Coffee.DataAccess.Repository.Wards
{
	public class WardRepository : BaseRepository<Ward>, IWardRepository
	{
		public WardRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}