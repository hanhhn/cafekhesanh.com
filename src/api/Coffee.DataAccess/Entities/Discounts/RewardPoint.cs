using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities.Discounts
{
	public class RewardPoint : BaseEntity<int>
	{
		public string Phone { get; set; }
		public decimal Point { get; set; }
	}
}