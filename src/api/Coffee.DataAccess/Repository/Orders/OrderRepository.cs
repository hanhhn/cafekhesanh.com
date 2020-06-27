using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}