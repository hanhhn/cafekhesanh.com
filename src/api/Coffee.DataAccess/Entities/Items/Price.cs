using Coffee.Libs.DataAccess.EntityRoot;
using System;

namespace Coffee.DataAccess.Entities
{
	public class Price : BaseEntity<int>
	{
		public int ItemId { get; set; }
		public decimal Rate { get; set; }
		public byte Tax { get; set; }
		public byte Priority { get; set; }
		public bool IsActive { get; set; }
		public DateTime ApplyDate { get; set; }
		public DateTime ExpireDate { get; set; }
	}
}