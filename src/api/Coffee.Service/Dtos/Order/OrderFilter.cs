using Coffee.Core.Enums;

namespace Coffee.Service.Dtos.Order
{
	public class OrderFilter
	{
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
		public string Keyword { get; set; }
	}
}
