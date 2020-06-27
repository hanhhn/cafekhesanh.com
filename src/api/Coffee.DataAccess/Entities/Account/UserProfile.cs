using Coffee.Libs.DataAccess.EntityRoot;
using Coffee.Libs.DataAccess.Identity.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee.DataAccess.Entities
{
	public class UserProfile : BaseEntity<string>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDay { get; set; }
		public bool Gender { get; set; }
		public string ProfileImage { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string Thinking { get; set; }

		[ForeignKey("User")]
		public string UserId { get; set; }
		public virtual AppUser User { get; set; }
	}
}
