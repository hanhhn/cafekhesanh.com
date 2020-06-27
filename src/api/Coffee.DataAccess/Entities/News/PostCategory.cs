using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities.News
{
	public class PostCategory : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
