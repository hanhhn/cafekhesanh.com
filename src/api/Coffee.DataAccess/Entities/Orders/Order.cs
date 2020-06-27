using Coffee.Libs.DataAccess.EntityRoot;
using System.Collections.Generic;

namespace Coffee.DataAccess.Entities
{
	public class Order : BaseEntity<string>
	{
		public string OrderCode { get; set; }
		public string Phone { get; set; }
		public string FullName { get; set; }
		public string Province { get; set; }
		public string District { get; set; }
		public string Ward { get; set; }
		public string Street { get; set; }

		public virtual ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
