using Cf.Libs.Core.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cf.Libs.DataAccess.Entities.Resource
{
	public class File : BaseEntity<int>
	{
		public string Url { get; set; }
		public int Size { get; set; }
		public string Format { get; set; }
	}
}
