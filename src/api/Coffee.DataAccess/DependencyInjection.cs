using Coffee.DataAccess.Repository;
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