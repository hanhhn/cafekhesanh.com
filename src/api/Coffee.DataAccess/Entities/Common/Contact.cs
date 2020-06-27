using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities
{
	public class Contact : BaseEntity<int>
	{
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Content { get; set; }
		public bool Seen { get; set; }
	}
}