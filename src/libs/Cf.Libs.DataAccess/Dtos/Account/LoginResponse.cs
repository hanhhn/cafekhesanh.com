using Cf.Libs.Core.BaseObject;
using System.Collections.Generic;

namespace Cf.Libs.DataAccess.Dtos.Account
{
	public class LoginResponse
	{
		public string Token { get; set; }
		public string Image { get; set; }
		public string FullName { get; set; }
		public List<string> Role { get; set; }
	}
}
