using Cf.Libs.Core.Infrastructure.DataAccess;
using Cf.Libs.DataAccess.DbContext;
using Cf.Libs.DataAccess.Entities;
using System;

namespace Cf.Libs.DataAccess.Repository.Pages
{
	public class PageRepository : BaseRepository<Page>, IPageRepository
    {
        public PageRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Page GetByUrl(string url)
        {
			throw new NotImplementedException();
        }
    }
}