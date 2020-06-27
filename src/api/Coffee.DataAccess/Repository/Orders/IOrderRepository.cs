using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities.Orders;

namespace Coffee.DataAccess.Repository.Orders
{
	public interface IOrderRepository : IBaseRepository<Order>
	{
	}
}