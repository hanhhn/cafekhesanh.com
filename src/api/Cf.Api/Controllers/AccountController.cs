using Cf.Libs.Service.Accounts;
using Cf.Libs.DataAccess.Dtos.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cf.Api.Controllers
{
	[Route("api/account")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly IAccountService _service;

		public AccountController(IAccountService service)
		{
			_service = service;
		}

		[HttpPost]
		[Route("signin")]
		public async Task<LoginResponse> SigninAsync(SigninDto model)
		{
			if (ModelState.IsValid)
			{
				return await _service.SigninAsyn(model).ConfigureAwait(true);
			}

			throw new ApplicationException();
		}

		[HttpPost]
		[Route("signup")]
		public async Task<bool> SignupAsync(SignupDto model)
		{
			if (ModelState.IsValid)
			{
				return await _service.SignupAsyn(model).ConfigureAwait(true);
			}
			return false;
		}

		[HttpPost]
		[Route("signout")]
		public async Task Signout()
		{
			await _service.SignoutAsyn().ConfigureAwait(true);
		}

		[HttpPost]
		[Route("forget")]
		public async Task<bool> ForgetPassoword(string email)
		{
			return await _service.ForgetPassowordAsyn(email).ConfigureAwait(true);
		}

		[HttpPost]
		[Route("reset")]
		public async Task<bool> ResetPassoword(ResetPasswordRequest model)
		{
			if (ModelState.IsValid)
			{
				return await _service.ResetPassowordAsyn(model).ConfigureAwait(true);
			}
			return false;
		}

		[HttpPost]
		[Route("password")]
		public async Task<bool> ConfirmPassoword([FromQuery] string email, [FromQuery] string token, [FromBody] string password)
		{
			return await _service.ConfirmPassowordAsyn(email, token, password).ConfigureAwait(true);
		}

		[HttpPost]
		[Route("confirm")]
		public async Task<bool> ConfirmEmail([FromQuery] string email, [FromRoute] string token)
		{
			return await _service.ConfirmEmailAsyn(email, token).ConfigureAwait(true);
		}

		[HttpPost]
		[Route("apply")]
		public async Task<bool> ApplyRoles(ApplyRoleRequest model)
		{
			if (ModelState.IsValid)
			{
				return await _service.ApplyRoles(model).ConfigureAwait(true);
			}
			return false;
		}

		[HttpGet]
		[Route("accessdenied")]
		public object AccessDenied()
		{
			return new
			{
				Status = 403,
				Message = "You don't have permision."
			};
		}
	}
}