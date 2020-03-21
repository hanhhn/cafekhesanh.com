using Cf.Libs.Core.Infrastructure.Entity;

namespace Cf.Libs.DataAccess.Entities.News
{
	public class PostCategory : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
