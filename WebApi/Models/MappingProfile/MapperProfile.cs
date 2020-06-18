using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models.Entities;
using WebApi.Models.ModelView;

namespace WebApi.Models.MappingProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryMv>();
            CreateMap<CategoryMv,Category > ();
            CreateMap<Product, ProductMv>(); 
            CreateMap<ProductMv, Product>();
            CreateMap<Image, ImageMv>();
            CreateMap<ImageMv,Image>();
            CreateMap<Cart, CartMv>();
            CreateMap<CartMv,Cart>();
            CreateMap<TypeProduct, TypeProductMv>();
            CreateMap<TypeProductMv,TypeProduct>();
            CreateMap<Order, OrderMv>();
            CreateMap<OrderMv, Order>();
            CreateMap<OrderDetail, OrderDetailMv>();
            CreateMap<OrderDetailMv,OrderDetail>();
        }
    }
}
