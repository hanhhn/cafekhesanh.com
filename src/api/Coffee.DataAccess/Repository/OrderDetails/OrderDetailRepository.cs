using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.DataAccess.Repository.OrderDetails
{
	public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
	{
		public OrderDetailRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}