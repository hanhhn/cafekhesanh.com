using Newtonsoft.Json;
using Coffee.Libs.Core;
using Coffee.Libs.Infrastructure.ClientService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Coffee.Libs.Infrastructure
{
	public static class HttpClientExcention
	{
		public static DefaultRequest GetClient(string clientName)
		{
			if (string.IsNullOrEmpty(clientName))
				throw new Exception("Unknow client name!");

			var client = SingletonList<DefaultRequest>.Instance.FirstOrDefault(t => t.Name.ToUpper() == clientName.ToUpper());
			if (client == null)
				throw new Exception(string.Format("Cannot found client name: {0}", clientName));

			return client;
		}

		public static void HttpClientFromFile(string clients = "clients.json")
		{
			var contents = File.ReadAllText(clients);
			var objs = JsonConvert.DeserializeObject<List<DefaultRequest>>(contents);
			if (objs == null || objs.Count == 0)
				throw new Exception("Unknow client name!");

			foreach (var item in objs)
			{
				SingletonList<DefaultRequest>.Instance.Add(item);
			}
		}
	}
}
