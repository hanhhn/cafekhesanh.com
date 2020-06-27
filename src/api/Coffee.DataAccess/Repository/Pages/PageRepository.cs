using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using System;

namespace Coffee.DataAccess.Repository.Pages
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