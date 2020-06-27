using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities
{
	public class FileResource : BaseEntity<int>
	{
		public string Url { get; set; }
		public int Size { get; set; }
		public string Format { get; set; }
	}
}
