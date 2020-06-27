namespace Coffee.Libs.Log
{
	public class LogEverything
	{
		public string ApplicationName { get; set; }
		public string ClientIP { get; set; }
		public int Elapsed { get; set; }
		public string EventType { get; set; }
		public string MachineName { get; set; }
		public string Outcome { get; set; }
		public string RequestMethod { get; set; }
		public string RequestPath { get; set; }
		public string SourceContext { get; set; }
		public string StatusCode { get; set; }
		public string UserAgent { get; set; }
		public string Version { get; set; }
	}

	public class Data
	{
		public string Parameters { get; set; }
		public string ReturnValue { get; set; }
	}

	public class Location
	{
		public string ClassName { get; set; }
		public string Namespace { get; set; }
		public string Function { get; set; }
		public string Module { get; set; }
	}
}
