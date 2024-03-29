﻿using Cf.Libs.DataAccess.Repository.Addresses;
using Cf.Libs.DataAccess.Repository.BillDetails;
using Cf.Libs.DataAccess.Repository.Bills;
using Cf.Libs.DataAccess.Repository.Contacts;
using Cf.Libs.DataAccess.Repository.Districts;
using Cf.Libs.DataAccess.Repository.OrderDetails;
using Cf.Libs.DataAccess.Repository.Orders;
using Cf.Libs.DataAccess.Repository.Pages;
using Cf.Libs.DataAccess.Repository.Posts;
using Cf.Libs.DataAccess.Repository.Prices;
using Cf.Libs.DataAccess.Repository.Provinces;
using Cf.Libs.DataAccess.Repository.Settings;
using Cf.Libs.DataAccess.Repository.Tags;
using Cf.Libs.DataAccess.Repository.Trackings;
using Cf.Libs.DataAccess.Repository.UserProfiles;
using Cf.Libs.DataAccess.Repository.Wards;
using Microsoft.Extensions.DependencyInjection;

namespace Cf.Libs.DataAccess
{
	public static class CfDataAccessRegister
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