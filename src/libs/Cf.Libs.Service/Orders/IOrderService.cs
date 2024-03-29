﻿using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Service.Dtos.Order;

namespace Cf.Libs.Service.Orders
{
    public interface IOrderService : IBaseService
    {
        OrderDto SaveOrder(OrderRequest request);
        bool UpdateOrderDetail(OrderDetailRequest request);
        IPagedList<OrderDto> Get(OrderFilter filter);
        OrderDto Get(string id);
    }
}
