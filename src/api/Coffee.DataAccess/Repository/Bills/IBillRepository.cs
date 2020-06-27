using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities.Billing;

namespace Coffee.DataAccess.Repository.Bills
{
	public interface IBillRepository : IBaseRepository<Bill>
	{
		Bill GetBill(string phone, string code);
	}
}