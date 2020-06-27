using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.News;
using System.Linq;

namespace Coffee.DataAccess.Repository.Posts
{
	public class PostRepository : BaseRepository<Post>, IPostRepository
	{
		public PostRepository(ApplicationDbContext context) : base(context)
		{
		}

		public Post GetByUrl(string url)
		{
			return DbSet.Where(x => x.UniqueUrl == url).SingleOrDefault();
		}
	}
}