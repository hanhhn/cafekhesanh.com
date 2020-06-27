using System.Collections.Generic;

namespace Coffee.Service.Dtos
{
	public class ApplyRoleRequest
	{
		public string UserId { get; set; }

		public List<string> Roles { get; set; } = new List<string>();
	}
}
