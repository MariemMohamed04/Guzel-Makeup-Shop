﻿using AutoMapper;
using E_Commerce.APIs.DTO;
using E_Commerce.Core.Entities;

namespace E_Commerce.APIs.Helpers
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Page, PageToReturnDto>()
                .ForMember(d => d.PageDescription, o => o.MapFrom(S => S.Description))
                .ForMember(d => d.PageName, o => o.MapFrom(S => S.name));

            CreateMap<Product, ProductToReturnDto>()
                       .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.name))
                       .ForMember(dest => dest.seller, opt => opt.MapFrom(src => src.seller.name))
                       .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors.Select(c => new ColorDto { Id = c.Id, HexValue = c.hex_value, ColourName=c.colour_name })));
            CreateMap<CustomerCartDto,customerCart>();
            CreateMap<CartItemDto, CartItem>();

        }
    } 
}
