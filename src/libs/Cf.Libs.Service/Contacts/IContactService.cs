using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.DataAccess.Dtos.Contact;

namespace Cf.Libs.Service.Contacts
{
    public interface IContactService : IBaseService
    {
        bool Add(ContactRequest request);
        bool Seen(int[] ids);
    }
}