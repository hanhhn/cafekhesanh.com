using Cf.Libs.Core.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cf.Libs.DataAccess.Entities.Activity
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
