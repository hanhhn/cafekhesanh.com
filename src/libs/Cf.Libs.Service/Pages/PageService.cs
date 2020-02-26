using AutoMapper;
using Cf.Libs.Core.Exeptions;
using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Repository.Pages;
using Cf.Libs.DataAccess.Repository.Settings;
using Cf.Libs.DataAccess.Repository.Tags;
using Cf.Libs.Service.Dtos.Page;
using System;
using System.Linq;

namespace Cf.Libs.Service.Pages
{
	public class PageService : BaseService, IPageService
    {
        public PageService(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public PageDto Get(string id)
        {
			throw new NotImplementedException();
		}

        public PageDto GetByUrl(string uniqueUrl)
        {
			throw new NotImplementedException();
		}

        public IPagedList<PageDto> GetAll(int pageIndex, int pageSize)
        {
			throw new NotImplementedException();
		}

        public bool IsUniqueUrl(string url)
        {
			throw new NotImplementedException();
		}


        public bool Save(PageRequest request)
        {
			throw new NotImplementedException();
		}

        public bool Delete(string id)
        {
			throw new NotImplementedException();
		}
    }
}