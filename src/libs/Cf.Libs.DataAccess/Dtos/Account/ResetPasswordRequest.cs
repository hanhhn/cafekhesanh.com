using System;
using System.Collections.Generic;
using System.Text;

namespace Cf.Libs.DataAccess.Dtos.Account
{
	public class ResetPasswordRequest
	{
		public string UserId { get; set; }
		public string Password { get; set; }
	}
}
