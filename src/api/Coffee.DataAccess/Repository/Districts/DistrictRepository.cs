using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class DistrictRepository : BaseRepository<District>, IDistrictRepository
	{
		public DistrictRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}