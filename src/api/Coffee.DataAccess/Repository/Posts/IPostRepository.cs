using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public interface IPostRepository : IBaseRepository<Post>
	{
		Post GetByUrl(string url);
	}
}