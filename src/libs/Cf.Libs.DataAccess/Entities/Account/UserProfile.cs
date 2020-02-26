using Cf.Libs.Core.Infrastructure.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cf.Libs.DataAccess.Entities.Account
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
		public string FullName => string.Format("{0} {1}", LastName, FirstName);

		[ForeignKey("User")]
		public string UserId { get; set; }
		public virtual User User { get; set; }
	}
}
