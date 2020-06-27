using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;
using System.Linq;

namespace Coffee.DataAccess.Repository
{
	public interface IAddressRepository : IBaseRepository<Address>
	{
		IQueryable<Address> FindByPhone(string phone);
	}
}