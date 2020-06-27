namespace Coffee.Service.Dtos
{
	public class BillDetailDto
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int Qty { get; set; }
		public decimal Rate { get; set; }
		public decimal Amount { get; set; }
	}
}