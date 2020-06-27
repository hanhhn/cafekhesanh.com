using AutoMapper;
using Coffee.DataAccess.Entities;
using Coffee.Libs.Infrastructure;
using Coffee.Service.Dtos;

namespace Coffee.Service
{
	public static class AutoMapperRegister
	{
		public static void AddAutoMapper(this IMapperConfigurationExpression configAction)
		{
			configAction.AddProfile<MapperProfile>();
		}
	}

	public class MapperProfile : AutoMapper.Profile
	{
		public MapperProfile()
		{
			CreateMap(typeof(PagedList<>), typeof(PagedList<>));
			CreateMap<ItemRequest, Product>();
			CreateMap<Product, ItemDto>();
			CreateMap<PriceRequest, Price>();
			CreateMap<Price, PriceDto>();
			CreateMap<AddressRequest, Address>();
			CreateMap<Address, AddressDto>();
			CreateMap<Province, AddressUnitDto>();
			CreateMap<District, AddressUnitDto>();
			CreateMap<Ward, AddressUnitDto>();
			CreateMap<ContactRequest, Contact>();
			CreateMap<OrderRequest, Address>();
			CreateMap<Order, OrderDto>();
			CreateMap<Tracking, TrackingDto>();
			CreateMap<OrderDetail, OrderDetailDto>();
			CreateMap<Post, PostDto>();
			CreateMap<PostRequest, Post>();
			CreateMap<Tag, TagDto>();
			CreateMap<PageRequest, Page>();
			CreateMap<Page, PageDto>();
			CreateMap<Bill, BillDto>();
			CreateMap<BillDetail, BillDetailDto>();
		}
	}
}