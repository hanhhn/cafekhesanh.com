namespace Cf.Libs.DataAccess.Dtos.Order
{
    public class OrderDetailRequest
    {
        public string OrderId { get; set; }
        public Detail[] Details { get; set; }
        public string Note { get; set; }
    }

    public class Detail
    {
        public int MethodId { get; set; }
        public float Qty { get; set; }
    }
}