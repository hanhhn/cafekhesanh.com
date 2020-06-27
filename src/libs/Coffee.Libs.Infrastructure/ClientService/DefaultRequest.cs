using System.Collections.Generic;

namespace Coffee.Libs.Infrastructure.ClientService
{
	public class DefaultRequest
	{
		public string Name { get; set; }
		public string BaseAddress { get; set; }
		public int Timeout { get; set; }
		public IDictionary<string, string> RequestHeaders { get; set; }
	}
}