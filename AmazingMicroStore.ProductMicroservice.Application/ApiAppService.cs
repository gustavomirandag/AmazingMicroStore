using AmazingMicroStore.ProductMicroservice.Application.AppModel.DTO;
using AmazingMicroStore.ProductMicroservice.Domain.CQRS.Commands;
using AmazingMicroStore.ProductMicroservice.Domain.Interfaces.CQRS;
using AmazingMicroStore.ProductMicroservice.Domain.ProductAggregate;
using AmazingMicroStore.ProductMicroservice.Domain.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazingMicroStore.ProductMicroservice.Application
{
    public class ApiAppService
    {
        private readonly IQueue _queue;
        private readonly IMapper _mapper;
        private readonly ProductService _productQueryService;

        public ApiAppService(IQueue queue, IMapper mapper, ProductService productQueryService)
        {
            _queue = queue;
            _mapper = mapper;
            _productQueryService = productQueryService;
        }

        //====== COMMANDS ======
        public void AddProduct(ProductDTO productDTO)
        {
            var command = _mapper.Map<AddProductCommand>(productDTO);
            _queue.Enqueue(command);
        }

        public void UpdateProduct(ProductDTO productDTO)
        {
            var command = _mapper.Map<UpdateProductCommand>(productDTO);
            _queue.Enqueue(command);
        }

        public void DeleteProduct(ProductDTO productDTO)
        {
            var command = _mapper.Map<DeleteProductCommand>(productDTO);
            _queue.Enqueue(command);
        }
        //======================


        //====== QUERIES ======
        public ProductDTO ReadProduct(Guid id)
        {
            var product = _productQueryService.GetProduct(id);
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = _productQueryService.GetAllProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
        //=====================
    }
}
