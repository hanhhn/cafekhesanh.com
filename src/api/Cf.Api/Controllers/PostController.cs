using Cf.Libs.Core.Infrastructure.Paging;
using Cf.Libs.DataAccess.Dtos.Post;
using Cf.Libs.Service.Posts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cf.Api.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;

        public PostController(IPostService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("get/{url}")]
        public PostDto GetByUrl(string url)
        {
            return _service.GetByUrl(url);
        }


        [HttpGet]
        [Route("detail/{id}")]
        public PostDto Get(string id)
        {
            return _service.Get(id);
        }

        [HttpGet]
        [Route("get")]
        public IPagedList<PostDto> GetAll(int pageIndex = 0, int pageSize = 10)
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
        public bool SavePost(PostRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException();
            }

            return _service.Save(request);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool Delete(string id)
        {
            return _service.Delete(id);
        }

        [HttpPost]
        [Route("published/{id}")]
        public bool Published(string id)
        {
            return _service.Published(id);
        }

        [HttpPost]
        [Route("upublished/{id}")]
        public bool UnPublished(string id)
        {
            return _service.UnPublished(id);
        }
    }
}