using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee.DataAccess.Entities.Account
{
	public class User : IdentityUser<string>, IEntityRoot
	{
		public DateTime LastPasswordChanged { get; set; }

		[ForeignKey("UserProfile")]
		public int UserProfileId { get; set; }
		public virtual UserProfile UserProfile { get; set; }
	}
}