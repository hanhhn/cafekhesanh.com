using Coffee.DataAccess.Repository.Addresses;
using Coffee.DataAccess.Repository.BillDetails;
using Coffee.DataAccess.Repository.Bills;
using Coffee.DataAccess.Repository.Contacts;
using Coffee.DataAccess.Repository.Districts;
using Coffee.DataAccess.Repository.OrderDetails;
using Coffee.DataAccess.Repository.Orders;
using Coffee.DataAccess.Repository.Pages;
using Coffee.DataAccess.Repository.Posts;
using Coffee.DataAccess.Repository.Prices;
using Coffee.DataAccess.Repository.Provinces;
using Coffee.DataAccess.Repository.Settings;
using Coffee.DataAccess.Repository.Tags;
using Coffee.DataAccess.Repository.Trackings;
using Coffee.DataAccess.Repository.UserProfiles;
using Coffee.DataAccess.Repository.Wards;
using Microsoft.Extensions.DependencyInjection;

namespace Coffee.DataAccess
{
	public static class DependencyInjection
	{
		public static void AddRepositories(this IServiceCollection services)
		{
			services.AddScoped<IAddressRepository, AddressRepository>();
			services.AddScoped<IProvinceRepository, ProvinceRepository>();
			services.AddScoped<IDistrictRepository, DistrictRepository>();
			services.AddScoped<IWardRepository, WardRepository>();
			services.AddScoped<IPriceRepository, PriceRepository>();
			services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<ISettingRepository, SettingRepository>();
			services.AddScoped<IUserProfileRepository, UserProfileRepository>();
			services.AddScoped<IPostRepository, PostRepository>();
			services.AddScoped<ITagRepository, TagRepository>();
			services.AddScoped<IPageRepository, PageRepository>();
			services.AddScoped<IContactRepository, ContactRepository>();
			services.AddScoped<ITrackingRepository, TrackingRepository>();
			services.AddScoped<IBillRepository, BillRepository>();
			services.AddScoped<IBillDetailRepository, BillDetailRepository>();
		}
	}
}