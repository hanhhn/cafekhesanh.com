using AutoMapper;
using Cf.Libs.Core.Enums;
using Cf.Libs.Core.Exeptions;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Entities.Orders;
using Cf.Libs.DataAccess.Repository.OrderDetails;
using Cf.Libs.DataAccess.Repository.Orders;
using Cf.Libs.DataAccess.Repository.Trackings;
using Cf.Libs.Service.Dtos.Method;
using Cf.Libs.Service.Dtos.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cf.Libs.Service.Trackings
{
    public class TrackingService : BaseService, ITrackingService
    {
        private readonly ITrackingRepository _trackingRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public TrackingService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ITrackingRepository trackingRepository,
            IOrderRepository orderRepository,
            IOrderDetailRepository orderDetailRepository) : base(unitOfWork, mapper)
        {
            _trackingRepository = trackingRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        public OrderHistoryDto Order(string phone, string orderCode)
        {
			throw new NotImplementedException();
        }
    }
}
