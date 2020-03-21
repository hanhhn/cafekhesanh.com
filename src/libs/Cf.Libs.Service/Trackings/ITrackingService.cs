using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.DataAccess.Dtos.Tracking;

namespace Cf.Libs.Service.Trackings
{
    public interface ITrackingService : IBaseService
    {
        OrderHistoryDto Order(string phone, string orderCode);
    }
}
