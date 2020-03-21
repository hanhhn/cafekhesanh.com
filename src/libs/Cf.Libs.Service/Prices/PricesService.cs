using AutoMapper;
using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Dtos.Price;
using System;

namespace Cf.Libs.Service.Prices
{
	public class PricesService : BaseService, IPriceService
    {

        public PricesService(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public PriceDto Add(PriceRequest request)
        {
			throw new NotImplementedException();
		}

        public PriceDto Edit(PriceRequest request)
        {
			throw new NotImplementedException();
		}

        public bool Delete(int id)
        {
			throw new NotImplementedException();
		}

        public PriceDto Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IPagedList<PriceDto> GetAll(int pageIndex, int pageSize)
        {
			throw new NotImplementedException();
		}
    }
}