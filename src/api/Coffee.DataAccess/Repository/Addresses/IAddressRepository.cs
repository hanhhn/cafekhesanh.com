using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities.Common;
using System.Linq;

namespace Coffee.DataAccess.Repository.Addresses
{
	public interface IAddressRepository : IBaseRepository<Address>
	{
		IQueryable<Address> FindByPhone(string phone);
	}
}