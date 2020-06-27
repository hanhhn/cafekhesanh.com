using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
	{
		public OrderDetailRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}