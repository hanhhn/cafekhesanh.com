using AutoMapper;
using Coffee.Libs.DataAccess.UnitOfWork;
using Coffee.Libs.Service;

namespace Coffee.Service
{
	public class AccountService : BaseService, IAccountService
	{
		public AccountService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
		{
		}
	}
}