﻿using Cf.Libs.Core.Infrastructure.Entity;
using System;

namespace Cf.Libs.DataAccess.Entities.Items
{
    public class Price : BaseEntity<int>
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public decimal Rate { get; set; }
        public byte Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountRate { get; set; }
        public byte Priority { get; set; }
        public bool IsActive { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}