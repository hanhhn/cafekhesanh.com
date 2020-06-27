using Coffee.Service.Dtos.Adress;
using Coffee.Service.Dtos.Billing;
using Coffee.Service.Dtos.Contact;
using Coffee.Service.Dtos.Item;
using Coffee.Service.Dtos.Order;
using Coffee.Service.Dtos.Page;
using Coffee.Service.Dtos.Post;
using Coffee.Service.Dtos.Price;
using Coffee.Service.Dtos.Tracking;
using Coffee.Service.Entities;
using Coffee.Service.Entities.Billing;
using Coffee.Service.Entities.Common;
using Coffee.Service.Entities.Items;
using Coffee.Service.Entities.News;
using Coffee.Service.Entities.Orders;

namespace Coffee.Application
{
	public class CfServiceProfile : AutoMapper.Profile
	{
		public CfServiceProfile()
		{
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