using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using Coffee.Libs.Core;
using Coffee.Libs.Infrastructure;
using System;

namespace Coffee.Libs.Log
{
	public class LogManager : ILogManger
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IIdentityContext _identityContext;

		public LogManager(IHttpContextAccessor httpContextAccessor, IIdentityContext identityContext, IConfiguration configuration)
		{
			_httpContextAccessor = httpContextAccessor;
			_identityContext = identityContext;

			if (Singleton<Logger>.Instance == null)
			{
				Singleton<Logger>.Instance = new LoggerConfiguration()
					.ReadFrom
					.Configuration(configuration)
					.CreateLogger();
			}
		}

		public void Information(string msg)
		{
			Singleton<Logger>.Instance.Information(msg);
		}

		public void BeforeChanged(LogEventType action, string table, object data)
		{
			var audit = new AuditableModel
			{
				Id = Guid.NewGuid(),
				TraceId = _httpContextAccessor.HttpContext.TraceIdentifier,
				Event = action.ToString(),
				BeforeAfter = "Before",
				Table = table,
				Adress = "",
				ModifiedUser = _identityContext.GetUserName(),
				Data = data
			};

			var msg = JsonConvert.SerializeObject(audit);
			Singleton<Logger>.Instance.Information(msg);
		}

		public void AfterChanged(LogEventType action, string table, object data)
		{
			var audit = new AuditableModel
			{
				Id = Guid.NewGuid(),
				TraceId = _httpContextAccessor.HttpContext.TraceIdentifier,
				Event = action.ToString(),
				BeforeAfter = "After",
				Table = table,
				Adress = "",
				ModifiedUser = _identityContext.GetUserName(),
				Data = data
			};

			var msg = JsonConvert.SerializeObject(audit);
			Singleton<Logger>.Instance.Information(msg);
		}
	}
}
