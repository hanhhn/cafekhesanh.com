using Cf.Libs.Core.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cf.Libs.DataAccess.Entities.Account
{
	public class User : IdentityUser<string>, IEntityRoot
    {
        public DateTime LastPasswordChanged { get; set; }

		[ForeignKey("UserProfile")]
		public int UserProfileId { get; set; }
        public virtual  UserProfile UserProfile { get; set; }
    }
}