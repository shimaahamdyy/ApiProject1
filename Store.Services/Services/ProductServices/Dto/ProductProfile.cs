﻿using AutoMapper;
using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Services.ProductServices.Dto
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product , ProductDetailsDto>()
                .ForMember(dest => dest.BrandName , options => options.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.TypeName , options => options.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.PictureUrl, options => options.MapFrom<ProductPictureUrlResolver>());

            CreateMap<ProductBrand, BrandsTypesDetailsDto>();
            CreateMap<ProductType, BrandsTypesDetailsDto>();
        }
    }
}
