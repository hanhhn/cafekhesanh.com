using Coffee.Libs.DataAccess.EntityRoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.DataAccess.Entities.Activity
{
	public class LogActivity : BaseEntity<Guid>
	{
		public string Identity { get; set; }
		public string Action { get; set; }
		public string Type { get; set; }
		public string Before { get; set; }
		public string After { get; set; }
	}
}
