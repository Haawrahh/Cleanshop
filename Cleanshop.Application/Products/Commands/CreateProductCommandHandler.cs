using Cleanshop.domain.Entities;
using Cleanshop.domain.Interfaces;
using MediatR;

namespace Cleanshop.Application.Products.Commands
{
    public class CreateProductCommandHandler
        : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(
            CreateProductCommand request,
            CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                CategoryId = request.CategoryId
            };

            return await _repository.AddAsync(product);
        }
    }
}