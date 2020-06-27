using Coffee.Core.Infrastructure.Paging;
using Coffee.DataAccess.Dtos.Page;
using Coffee.Service.Pages;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coffee.Api.Controllers
{
	[Route("api/page")]
	[ApiController]
	public class PageController : ControllerBase
	{
		private readonly IPageService _service;

		public PageController(IPageService service)
		{
			_service = service;
		}

		[HttpGet]
		[Route("get/{url}")]
		public PageDto GetByUrl(string url)
		{
			return _service.GetByUrl(url);
		}

		[HttpGet]
		[Route("detail/{id}")]
		public PageDto Get(string id)
		{
			return _service.Get(id);
		}

		[HttpGet]
		[Route("get")]
		public IPagedList<PageDto> GetAll(int pageIndex = 0, int pageSize = 10)
		{
			return _service.GetAll(pageIndex, pageSize);
		}

		[HttpGet]
		[Route("unique/{url}")]
		public bool IsUniqueUrl(string url)
		{
			return _service.IsUniqueUrl(url);
		}

		[HttpPost]
		[Route("save")]
		public bool SavePost(PageRequest request)
		{
			return _service.Save(request);
		}

		[HttpDelete]
		[Route("delete/{id}")]
		public bool Delete(string id)
		{
			return _service.Delete(id);
		}
	}
}