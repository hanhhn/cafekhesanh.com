using Coffee.Libs.DataAccess.EntityRoot;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee.DataAccess.Entities
{
	public class BillDetail : BaseEntity<int>
	{
		[ForeignKey("Bill")]
		public int BillId { get; set; }
		public string Description { get; set; }
		public float Qty { get; set; }
		public decimal Rate { get; set; }
		public decimal Amount { get; set; }

		public virtual Bill Bill { get; set; }
	}
}
