using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Billing;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository.BillDetails
{
	public class BillDetailRepository : BaseRepository<BillDetail>, IBillDetailRepository
	{
		public BillDetailRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}