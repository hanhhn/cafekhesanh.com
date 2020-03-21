using System;
using System.Collections.Generic;
using System.Text;

namespace Cf.Libs.DataAccess.Dtos.Account
{
	public class ChangePasswordRequest
	{
		public string UserId { get; set; }
		public string OldPassword { get; set; }
		public string NewPassword { get; set; }
	}
}
