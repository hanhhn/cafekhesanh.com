using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;
using System;

namespace Coffee.DataAccess.Repository
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