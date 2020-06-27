using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public interface IBillRepository : IBaseRepository<Bill>
	{
		Bill GetBill(string phone, string code);
	}
}