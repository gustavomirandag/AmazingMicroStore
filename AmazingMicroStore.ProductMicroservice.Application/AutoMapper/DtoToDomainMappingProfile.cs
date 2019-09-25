using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<ProductDTO, Product>();
        }
    }
}
