using Coffee.Libs.DataAccess.EntityRoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.DataAccess.Entities.Resource
{
	public class File : BaseEntity<int>
	{
		public string Url { get; set; }
		public int Size { get; set; }
		public string Format { get; set; }
	}
}
