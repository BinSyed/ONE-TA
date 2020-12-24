using AutoMapper;
using ONE_TA.Application.Features.Products.Commands.CreateProduct;
using ONE_TA.Application.Features.Products.Queries.GetAllProducts;
using ONE_TA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONE_TA.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
