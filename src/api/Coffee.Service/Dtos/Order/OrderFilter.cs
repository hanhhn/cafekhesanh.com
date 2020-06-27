namespace Coffee.Service.Dtos
{
	public class OrderFilter
	{
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
		public string Keyword { get; set; }
	}
}
