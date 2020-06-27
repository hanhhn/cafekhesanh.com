using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;
using System.Linq;

namespace Coffee.DataAccess.Repository
{
	public class AddressRepository : BaseRepository<Address>, IAddressRepository
	{
		public AddressRepository(ApplicationDbContext context) : base(context)
		{
		}

		public IQueryable<Address> FindByPhone(string phone)
		{
			var query = from item in DbSet
						where !item.IsDeleted && item.Phone == phone
						orderby item.IsDefault descending
						orderby item.ModifiedDate descending
						orderby item.ModifiedBy descending
						orderby item.Id ascending
						select item;
			return query;
		}
	}
}