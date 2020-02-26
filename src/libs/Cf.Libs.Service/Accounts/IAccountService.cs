using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Service.Dtos.Account;
using System.Threading.Tasks;

namespace Cf.Libs.Service.Accounts
{
	public interface IAccountService : IBaseService
    {
        Task<LoginResponse> SigninAsyn(SigninDto model);
        Task<bool> SignupAsyn(SignupDto model);
		Task SignoutAsyn();
		Task<bool> ForgetPassowordAsyn(string email);
		Task<bool> ChangePassowordAsyn(ChangePasswordRequest model);
		Task<bool> ResetPassowordAsyn(ResetPasswordRequest model);
		Task<bool> ConfirmPassowordAsyn(string email, string token, string password);
		Task<bool> ConfirmEmailAsyn(string email, string token);
		Task<bool> ApplyRoles(ApplyRoleRequest request);
	}
}