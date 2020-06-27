using Coffee.Libs.DataAccess.EntityRoot;
using System.Collections.Generic;

namespace Coffee.DataAccess.Entities
{
	public class Product : BaseEntity<int>
	{
		public string UniqueUrl { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Highlight { get; set; }
		public int SortOrder { get; set; }

		public IEnumerable<ProductGallery> Images { get; set; }
	}
}