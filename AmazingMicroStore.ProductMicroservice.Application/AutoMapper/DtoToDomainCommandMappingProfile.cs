using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands;
using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingMicroStore.ProductMicroservice.Application.AutoMapper
{
    public class DtoToDomainCommandMappingProfile : Profile
    {
        public DtoToDomainCommandMappingProfile()
        {
            var dtoConfig = AutoMapperConfig.RegisterDtoDomainMappings();
            var mapper = dtoConfig.CreateMapper();

            CreateMap<ProductDTO, AddProductCommand>()
                .ConstructUsing(a => new AddProductCommand(mapper.Map<ProductDTO, Product>(a)));

            CreateMap<ProductDTO, UpdateProductCommand>()
                .ConstructUsing(a => new UpdateProductCommand(mapper.Map<ProductDTO, Product>(a)));

            CreateMap<ProductDTO, DeleteProductCommand>()
                .ConstructUsing(a => new DeleteProductCommand(mapper.Map<ProductDTO, Product>(a)));
        }
    }
}
