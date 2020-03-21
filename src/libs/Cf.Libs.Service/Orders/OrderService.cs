using AutoMapper;
using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Dtos.Order;
using System;

namespace Cf.Libs.Service.Orders
{
	public class OrderService : BaseService, IOrderService
    {

        public OrderService(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public OrderDto SaveOrder(OrderRequest request)
        {
			throw new NotImplementedException();
        }

        public bool UpdateOrderDetail(OrderDetailRequest request)
        {
			throw new NotImplementedException();
		}

        public IPagedList<OrderDto> Get(OrderFilter filter)
        {
			throw new NotImplementedException();
		}

        public OrderDto Get(string id)
        {
			throw new NotImplementedException();
		}
    }
}