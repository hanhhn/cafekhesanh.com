using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Coffee.Libs.Log
{
	public class LoggerMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogManger _logger;

		private readonly Stopwatch _stopwatch;

		public LoggerMiddleware(RequestDelegate next, ILogManger logger)
		{
			_next = next;
			_logger = logger;
			_stopwatch = new Stopwatch();
		}

		public async Task Invoke(HttpContext context)
		{
			if (context.Request.GetDisplayUrl().Contains("/api"))
			{
				var executed = false;
				try
				{
					var requestBodyStream = new MemoryStream();
					var originalRequestBody = context.Request.Body;

					await context.Request.Body.CopyToAsync(requestBodyStream);
					requestBodyStream.Seek(0, SeekOrigin.Begin);

					var url = context.Request.GetDisplayUrl();
					var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

					var requestLog = new LogModel
					{
						Method = context.Request.Method,
						Url = url,
						Request = JsonConvert.DeserializeObject(requestBodyText),
						DateTime = DateTime.UtcNow
					};
					requestBodyStream.Seek(0, SeekOrigin.Begin);
					context.Request.Body = requestBodyStream;

					var bodyStream = context.Response.Body;
					var responseBodyStream = new MemoryStream();
					context.Response.Body = responseBodyStream;

					_stopwatch.Start();
					await _next.Invoke(context);
					executed = true;
					_stopwatch.Stop();
					requestLog.ElaspsedTime = _stopwatch.ElapsedMilliseconds;
					context.Request.Body = originalRequestBody;

					responseBodyStream.Seek(0, SeekOrigin.Begin);
					var responseBody = new StreamReader(responseBodyStream).ReadToEnd();
					requestLog.Response = JsonConvert.DeserializeObject(responseBody);

					_logger.Information(JsonConvert.SerializeObject(requestLog));
					responseBodyStream.Seek(0, SeekOrigin.Begin);
					await responseBodyStream.CopyToAsync(bodyStream);
				}
				catch (Exception exception)
				{
					if (!executed)
					{
						await _next.Invoke(context);
					}
				}
			}
			else
			{
				await _next.Invoke(context);
			}
		}
	}
}
