using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Common;

namespace Coffee.DataAccess.Repository.Districts
{
	public class DistrictRepository : BaseRepository<District>, IDistrictRepository
	{
		public DistrictRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}