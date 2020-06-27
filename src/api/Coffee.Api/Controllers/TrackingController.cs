using Coffee.DataAccess.Dtos.Tracking;
using Coffee.Service.Trackings;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers
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