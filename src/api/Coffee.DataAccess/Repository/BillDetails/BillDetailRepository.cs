using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class BillDetailRepository : BaseRepository<BillDetail>, IBillDetailRepository
	{
		public BillDetailRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}