using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class PriceRepository : BaseRepository<Price>, IPriceRepository
	{
		public PriceRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}