using Cf.Libs.Core.Enums;
using Cf.Libs.Core.Infrastructure.Entity;
using Cf.Libs.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cf.Libs.DataAccess.Entities.Orders
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
