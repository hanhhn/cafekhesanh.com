using System;

namespace Coffee.Libs.Log
{
	public class AuditableModel
	{
		public Guid Id { get; set; }
		public string TraceId { get; set; }
		public string Adress { get; set; }
		public string ModifiedUser { get; set; }
		public string Event { get; set; }
		public string BeforeAfter { get; set; }
		public string Table { get; set; }
		public string Query { get; set; }
		public object Data { get; set; }
	}
}