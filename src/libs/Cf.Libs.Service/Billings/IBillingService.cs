using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.DataAccess.Dtos.Billing;

namespace Cf.Libs.Service.Billings
{
    public interface IBillingService : IBaseService
    {
        BillDto Get(int id);
        BillDto Publish(string orderId);
        bool UnPublish(string orderId);
    }
}