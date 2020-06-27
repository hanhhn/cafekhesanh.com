using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Billing;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Coffee.DataAccess.Repository.Bills
{
	public class BillRepository : BaseRepository<Bill>, IBillRepository
	{
		public BillRepository(ApplicationDbContext context) : base(context)
		{
		}

		public override IQueryable<Bill> GetQuery()
		{
			return base.GetQuery().Include(x => x.BillDetails);
		}

		public Bill GetBill(string phone, string code)
		{
			return DbSet.Where(x => x.Phone == phone && x.OrderCode == code).SingleOrDefault();
		}
	}
}