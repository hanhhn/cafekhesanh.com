using AutoMapper;
using Cf.Libs.DataAccess.Entities;
using Cf.Libs.DataAccess.Entities.Billing;
using Cf.Libs.DataAccess.Entities.Common;
using Cf.Libs.DataAccess.Entities.Items;
using Cf.Libs.DataAccess.Entities.News;
using Cf.Libs.DataAccess.Entities.Orders;
using Cf.Libs.DataAccess.Dtos.Adress;
using Cf.Libs.DataAccess.Dtos.Billing;
using Cf.Libs.DataAccess.Dtos.Contact;
using Cf.Libs.DataAccess.Dtos.Item;
using Cf.Libs.DataAccess.Dtos.Method;
using Cf.Libs.DataAccess.Dtos.Order;
using Cf.Libs.DataAccess.Dtos.Page;
using Cf.Libs.DataAccess.Dtos.Post;
using Cf.Libs.DataAccess.Dtos.Price;
using Cf.Libs.DataAccess.Dtos.Setting;
using Cf.Libs.DataAccess.Dtos.Tracking;

namespace Cf.Libs.Service
{
	public static class CfServiceMapper
    {
        public static void AddCoreMapper(this IMapperConfigurationExpression configAction)
        {
            configAction.AddProfile<CfServiceProfile>();
        }
    }

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
            CreateMap<OrderDetail, MethodDto>()
                .ForMember(x => x.Id, y => y.MapFrom(a => a.MethodId))
                .ForMember(x => x.Name, y => y.MapFrom(a => a.MethodName))
                .ForMember(x => x.Description, y => y.MapFrom(a => a.Description))
                .ForMember(x => x.Type, y => y.MapFrom(a => a.Type));
            CreateMap<Tracking, TrackingDto>();
            CreateMap<OrderDetail, OrderDetailDto>();


            CreateMap<Post, PostDto>();
            CreateMap<PostRequest, Post>();
            CreateMap<Tag, TagDto>();

            CreateMap<JumbotronDto, ItemCombo>();

            CreateMap<PageRequest, Page>();
            CreateMap<Page, PageDto>();

            CreateMap<Bill, BillDto>();
            CreateMap<BillDetail, BillDetailDto>();
        }
    }
}