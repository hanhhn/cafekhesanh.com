using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Items;

namespace Coffee.DataAccess.Repository.Prices
{
	public class PriceRepository : BaseRepository<Price>, IPriceRepository
	{
		public PriceRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}