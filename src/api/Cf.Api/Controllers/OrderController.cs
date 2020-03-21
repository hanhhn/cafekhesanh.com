using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.DataAccess.Dtos.Order;
using Cf.Libs.Service.Orders;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cf.Api.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Route("save")]
        public OrderDto SaveOrder(OrderRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(typeof(OrderDetailRequest).ToString());
            }

            return _orderService.SaveOrder(request);
        }

        [HttpPost]
        [Route("update")]
        public bool UpdateOrderDetail(OrderDetailRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(typeof(OrderDetailRequest).ToString());
            }

            return _orderService.UpdateOrderDetail(request);
        }

        [HttpGet]
        [Route("get")]
        public IPagedList<OrderDto> GetOrders([FromQuery] OrderFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(typeof(OrderFilter).ToString());
            }

            return _orderService.Get(filter);
        }

        [HttpGet]
        [Route("get/{id}")]
        public OrderDto GetOrder(string id)
        {
            return _orderService.Get(id);
        }
    }
}