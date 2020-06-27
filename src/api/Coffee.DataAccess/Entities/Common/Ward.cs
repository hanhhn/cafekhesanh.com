using Coffee.Libs.DataAccess.EntityRoot;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee.DataAccess.Entities.Common
{
	public class Ward : IEntityRoot
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Prefix { get; set; }
		[ForeignKey("District")]
		public int DistrictId { get; set; }
		public int SortOrder { get; set; }
		public bool IsPublished { get; set; }
		public bool IsDeleted { get; set; }
		public virtual District District { get; set; }
	}
}