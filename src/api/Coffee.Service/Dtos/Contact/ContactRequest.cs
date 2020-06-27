using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Service.Dtos.Contact
{
	public class ContactRequest
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Content { get; set; }
	}
}
