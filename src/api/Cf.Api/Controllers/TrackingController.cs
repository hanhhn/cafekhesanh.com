using Cf.Libs.DataAccess.Dtos.Tracking;
using Cf.Libs.Service.Trackings;
using Microsoft.AspNetCore.Mvc;

namespace Cf.Api.Controllers
{
    [Route("api/tracking")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private readonly ITrackingService _trackingService;

        public TrackingController(ITrackingService trackingService)
        {
            _trackingService = trackingService;
        }

        [HttpGet]
        [Route("order/{phone}/{code}")]
        public OrderHistoryDto Order(string phone, string code)
        {
            return _trackingService.Order(phone, code);
        }
    }
}