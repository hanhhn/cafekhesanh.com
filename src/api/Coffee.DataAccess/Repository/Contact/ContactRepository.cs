using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class ContactRepository : BaseRepository<Contact>, IContactRepository
	{
		public ContactRepository(ApplicationDbContext context) : base(context)
		{
		}

	}
}