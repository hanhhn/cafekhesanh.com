using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities.News;

namespace Coffee.DataAccess.Repository.Posts
{
	public interface IPostRepository : IBaseRepository<Post>
	{
		Post GetByUrl(string url);
	}
}