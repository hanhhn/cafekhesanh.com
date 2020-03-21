using AutoMapper;
using Cf.Libs.Core.Exeptions;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Entities.Billing;
using Cf.Libs.DataAccess.Repository.Addresses;
using Cf.Libs.DataAccess.Repository.BillDetails;
using Cf.Libs.DataAccess.Repository.Bills;
using Cf.Libs.DataAccess.Repository.OrderDetails;
using Cf.Libs.DataAccess.Repository.Orders;
using Cf.Libs.DataAccess.Repository.Prices;
using Cf.Libs.DataAccess.Repository.Trackings;
using Cf.Libs.DataAccess.Dtos.Billing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cf.Libs.Service.Billings
{
	public class BillingService : BaseService, IBillingService
    {
        public BillingService(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public BillDto Get(int id)
        {
			throw new NotImplementedException();
		}

        public BillDto Publish(string orderId)
        {
			throw new NotImplementedException();
		}

        public bool UnPublish(string orderId)
        {
            throw new NotImplementedException();
        }
    }
}