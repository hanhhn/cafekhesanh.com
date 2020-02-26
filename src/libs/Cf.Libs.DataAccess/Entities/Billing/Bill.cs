using Cf.Libs.Core.Infrastructure.Entity;
using System.Collections.Generic;

namespace Cf.Libs.DataAccess.Entities.Billing
{
    public class Bill : BaseEntity<int>
    {
        public string BillCode { get; set; }
        public string OrderCode { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Coupon { get; set; }
        public int Discount { get; set; }
        public decimal Amount { get; set; }
        public decimal BillAmount { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
