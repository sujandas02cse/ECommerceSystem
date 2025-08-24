﻿using AutoMapper;
using ProductService.Application.DTOs;
using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()

        {

            // Product mappings 

            CreateMap<ProductCreateDTO, Product>()

                .ForMember(dest => dest.Id, opt => opt.Ignore())

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<ProductUpdateDTO, Product>()

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<Product, ProductDTO>();



            // Category mappings 

            CreateMap<CategoryCreateDTO, Category>()

                .ForMember(dest => dest.Id, opt => opt.Ignore())

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<CategoryUpdateDTO, Category>()

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<Category, CategoryDTO>();



            // Discount mappings 

            CreateMap<DiscountCreateDTO, Discount>()

                .ForMember(dest => dest.Id, opt => opt.Ignore())

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<DiscountUpdateDTO, Discount>()

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<Discount, DiscountDTO>();



            // ProductImage mappings 

            CreateMap<ProductImageCreateDTO, ProductImage>()

                .ForMember(dest => dest.Id, opt => opt.Ignore())

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<ProductImageUpdateDTO, ProductImage>()

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<ProductImage, ProductImageDTO>();



            // Review mappings 

            CreateMap<ReviewCreateDTO, Review>()

                .ForMember(dest => dest.Id, opt => opt.Ignore())

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<ReviewUpdateDTO, Review>()

                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())

                .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());



            CreateMap<Review, ReviewDTO>()

                .ForMember(

                    dest => dest.Comments,     // Destination member: ReviewDTO.Comments 

                    opt => opt.MapFrom(src => src.Comment) // Mapping logic: take the value from Review.Comment 

                );

        }
    }
}
