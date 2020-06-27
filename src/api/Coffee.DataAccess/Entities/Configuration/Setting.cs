using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities
{
	public class Setting : BaseEntity<string>
	{
		public string Name { get; set; }

		public string Value { get; set; }
	}
}
