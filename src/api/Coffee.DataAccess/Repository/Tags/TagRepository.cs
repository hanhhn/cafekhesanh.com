using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Common;

namespace Coffee.DataAccess.Repository.Tags
{
	public class TagRepository : BaseRepository<Tag>, ITagRepository
	{
		public TagRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}