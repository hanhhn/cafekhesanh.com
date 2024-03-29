﻿using Cf.Libs.Service.Contacts;
using Cf.Libs.Service.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Cf.Api.Controllers
{
    [Route("api/contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService ;

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