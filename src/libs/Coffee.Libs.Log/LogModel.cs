using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Libs.Log
{
	public class LogModel
	{
		public DateTime DateTime { get; set; }

		public string Method { get; set; }

		public string Url { get; set; }

		public object Request { get; set; }

		public object Response { get; set; }

		public long ElaspsedTime { get; set; }
	}
}
