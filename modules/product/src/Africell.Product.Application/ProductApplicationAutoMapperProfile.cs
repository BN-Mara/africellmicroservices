using Africell.Product.Products;
using Africell.Product.Products.Goods;
using Africell.Product.Products.Services;
using AutoMapper;
using Newtonsoft.Json.Linq;
using System;

namespace Africell.Product
{
    public class ProductApplicationAutoMapperProfile : Profile
    {
        public ProductApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Products.Product, ProductDto>();//.ForMember(u => u.Metadata, options => options.MapFrom(c => JObject.Parse(c.Metadata)));

            CreateMap<Service, ServiceDto>();//.ForMember(u => u.Metadata, options => options.MapFrom(c => JObject.Parse(c.Metadata)));
            CreateMap<CreateServiceDto, Service>();//.ForMember(u => u.Metadata, options => options.MapFrom(c => c.Metadata.ToString()));
            CreateMap<Good, GoodDto>();//.ForMember(u => u.Metadata, options => options.MapFrom(c => JObject.Parse(c.Metadata)));
            CreateMap<CreateGoodDto, Good>();//.ForMember(u => u.Metadata, options => options.MapFrom(c => c.Metadata.ToString()));
        }
        
    }
}