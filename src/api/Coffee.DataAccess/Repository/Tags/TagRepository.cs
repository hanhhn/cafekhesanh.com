using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class TagRepository : BaseRepository<Tag>, ITagRepository
	{
		public TagRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}