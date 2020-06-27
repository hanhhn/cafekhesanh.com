using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Orders;

namespace Coffee.DataAccess.Repository.Trackings
{
	public class TrackingRepository : BaseRepository<Tracking>, ITrackingRepository
	{
		public TrackingRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}