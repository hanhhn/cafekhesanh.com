using System.Collections.Generic;

namespace Cf.Libs.Service.Dtos.Account
{
	public class ApplyRoleRequest
	{
		public string UserId { get; set; }

		public List<string> Roles { get; set; } = new List<string>();
	}
}
