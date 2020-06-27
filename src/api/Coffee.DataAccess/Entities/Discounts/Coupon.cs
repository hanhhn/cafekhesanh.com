using Coffee.Libs.DataAccess.EntityRoot;
using System;

namespace Coffee.DataAccess.Entities.Discounts
{
	public class Coupon : BaseEntity<int>
	{
		public string Code { get; set; }
		public int Apply { get; set; }
		public int Count { get; set; }
		public DateTime ApplyDate { get; set; }
		public DateTime ExpireDate { get; set; }
	}
}