using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class TrackingRepository : BaseRepository<Tracking>, ITrackingRepository
	{
		public TrackingRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}