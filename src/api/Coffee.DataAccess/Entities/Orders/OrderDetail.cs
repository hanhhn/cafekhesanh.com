using Coffee.Libs.DataAccess.EntityRoot;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee.DataAccess.Entities.Orders
{
	public class OrderDetail : BaseEntity<int>
	{
		[ForeignKey("Order")]
		public string OrderId { get; set; }
		public int ItemId { get; set; }
		public float Qty { get; set; }
		public virtual Order Order { get; set; }
	}
}