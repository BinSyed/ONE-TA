﻿using AutoMapper;
using MediatR;
using ONE_TA.Application.Interfaces.Repositories;
using ONE_TA.Application.Wrappers;
using ONE_TA.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ONE_TA.Application.Features.Products.Commands.CreateProduct
{
    public partial class CreateProductCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<int>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _productRepository.AddAsync(product);
            return new Response<int>(product.Id);
        }
    }
}
