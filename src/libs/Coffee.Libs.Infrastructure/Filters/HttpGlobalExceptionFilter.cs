using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Coffee.Libs.Common;
using Coffee.Libs.Common.Types;
using Coffee.Libs.Core.Exeptions;

namespace Coffee.Libs.Infrastructure
{
	public class HttpGlobalExceptionFilter : IExceptionFilter
	{
		private readonly IWebHostEnvironment env;
		private readonly ILogger<HttpGlobalExceptionFilter> logger;

		public HttpGlobalExceptionFilter(IWebHostEnvironment env, ILogger<HttpGlobalExceptionFilter> logger)
		{
			this.env = env;
			this.logger = logger;
		}

		public void OnException(ExceptionContext context)
		{
			logger.LogError(new EventId(context.Exception.HResult),
				context.Exception,
				context.Exception.Message);

			DefaultContractResolver contractResolver = new DefaultContractResolver
			{
				NamingStrategy = new CamelCaseNamingStrategy()
			};

			if (context.Exception as SnpException != null)
			{
				var exception = (SnpException)context.Exception;
				var obj = new TResponse<object>
				{
					Status = ErrorCode.Error,
					Errors = new[] { exception.Message }
				};

				var result = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
				{
					ContractResolver = contractResolver,
					Formatting = Formatting.Indented
				});
				context.HttpContext.Response.ContentType = "application/json";
				context.HttpContext.Response.WriteAsync(result);
			}
			else
			{
				var obj = new TResponse<object>
				{
					Status = ErrorCode.Error,
					Errors = new[] { context.Exception.Message }
				};

				var result = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
				{
					ContractResolver = contractResolver,
					Formatting = Formatting.Indented
				});
				context.HttpContext.Response.ContentType = "application/json";
				context.HttpContext.Response.WriteAsync(result);
			}

			context.ExceptionHandled = true;
		}
	}
}
