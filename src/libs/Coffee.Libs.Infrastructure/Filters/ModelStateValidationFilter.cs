using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Coffee.Libs.Common;
using Coffee.Libs.Common.Types;
using System.Linq;
using System.Net;

namespace Coffee.Libs.Infrastructure
{
	public class ModelStateValidationFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (context.ModelState.IsValid)
				return;

			var errors = from state in context.ModelState.Values
						 from error in state.Errors
						 select error.ErrorMessage;

			var obj = new TResponse<object>
			{
				Status = ErrorCode.Error,
				Errors = errors.ToArray()
			};

			DefaultContractResolver contractResolver = new DefaultContractResolver
			{
				NamingStrategy = new CamelCaseNamingStrategy()
			};

			var result = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
			{
				ContractResolver = contractResolver,
				Formatting = Formatting.Indented
			});
			context.Result = new BadRequestResult();
			context.HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
			context.HttpContext.Response.ContentType = "application/json";
			context.HttpContext.Response.WriteAsync(result);
		}
	}
}
