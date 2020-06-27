using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities.Configuration
{
	public class Setting : BaseEntity<string>
	{
		public string Name { get; set; }

		public string Value { get; set; }
	}
}
