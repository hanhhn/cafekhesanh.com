using AutoMapper;
using Coffee.Core.Infrastructure.Engine;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers
{
	[Route("api/values")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]
		[Route("index")]
		public object Get()
		{
			var mapper = EngineContext.Current.Resolve<IMapper>();
			return new { code = mapper.ToString() };
		}
	}
}
