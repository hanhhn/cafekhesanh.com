using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;
using System.Linq;

namespace Coffee.DataAccess.Repository
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