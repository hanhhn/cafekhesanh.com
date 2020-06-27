using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Coffee.Libs.Core.Exeptions;
using System.Threading.Tasks;

namespace Coffee.Libs.Infrastructure
{
	[ApiController]
	[Route("api/v{version:apiVersion}")]
	public abstract class ApiController : ControllerBase
	{
		protected IMediator Mediator
		{
			get
			{
				IMediator mediator = HttpContext.RequestServices.GetService<IMediator>();
				if (mediator == null)
					throw new InformationException("IMediator can not be resolve");

				return mediator;
			}
		}

		/// <summary>
		/// QueryAsync use for Query
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="query"></param>
		/// <returns></returns>
		protected async Task<TResult> QueryAsync<TResult>(IRequest<TResult> query)
		{
			return await Mediator.Send(query);
		}

		/// <summary>
		/// CommandAsync use for Command
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="command"></param>
		/// <returns></returns>
		protected async Task<TResult> CommandAsync<TResult>(IRequest<TResult> command)
		{
			return await Mediator.Send(command);
		}

		/// <summary>
		/// use for check the response data
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data"></param>
		/// <returns></returns>
		protected ActionResult<T> Single<T>(T data)
		{
			if (data == null) return NotFound();
			return Ok(data);
		}
	}
}
