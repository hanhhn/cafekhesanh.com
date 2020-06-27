using Coffee.Service.Contacts;
using Coffee.DataAccess.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers
{
	[Route("api/contact")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;

		public ContactController(IContactService service)
		{
			_contactService = service;
		}

		[HttpPost]
		[Route("save")]
		public bool SaveContact(ContactRequest request)
		{
			return _contactService.Add(request);
		}
	}
}