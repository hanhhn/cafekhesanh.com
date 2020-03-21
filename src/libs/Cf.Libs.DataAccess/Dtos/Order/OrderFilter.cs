using Cf.Libs.Core.Enums;

namespace Cf.Libs.DataAccess.Dtos.Order
{
    public class OrderFilter
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Keyword { get; set; }
    }
}
