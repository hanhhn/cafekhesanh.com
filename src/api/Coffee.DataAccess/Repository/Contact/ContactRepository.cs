using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Common;

namespace Coffee.DataAccess.Repository.Contacts
{
	public class ContactRepository : BaseRepository<Contact>, IContactRepository
	{
		public ContactRepository(ApplicationDbContext context) : base(context)
		{
		}

	}
}