using System;
using System.Collections.Generic;

namespace Coffee.Service.Dtos
{
	public class OrderHistoryDto
	{
		public string OrderCode { get; set; }
		public DateTime PurchaseDate { get; set; }
		public IEnumerable<MethodDto> Services { get; set; }
		public IEnumerable<TrackingDto> OrderStatus { get; set; }
		public decimal Amount { get; set; }
		//public PaymentStatus PaymentStatus { get; set; }
		public DateTime DateOfReceipt { get; set; }
		public string HoursOfReceipt { get; set; }
		public string FullAddress { get; set; }
		//public string Payment => PaymentStatus.ToString();
	}
}