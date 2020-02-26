using Cf.Libs.Core.Infrastructure.DataAccess;
using Cf.Libs.DataAccess.DbContext;
using Cf.Libs.DataAccess.Entities.Items;

namespace Cf.Libs.DataAccess.Repository.Prices
{
	public class PriceRepository : BaseRepository<Price>, IPriceRepository
    {
        public PriceRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}