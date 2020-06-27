using Coffee.Service;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.v1.Controllers
{
	[ApiController]
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/account")]
	public class AccountController : ControllerBase
	{
		private readonly IAccountService _service;

		public AccountController(IAccountService service)
		{
			_service = service;
		}
	}
}