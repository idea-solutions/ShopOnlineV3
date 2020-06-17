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
            CreateMap<Image, ImageMv>();
            CreateMap<Cart, CartMv>();
            CreateMap<TypeProduct, TypeProductMv>();
            CreateMap<Order, OrderMv>();
            CreateMap<OrderDetail, OrderDetailMv>();
        }
    }
}
