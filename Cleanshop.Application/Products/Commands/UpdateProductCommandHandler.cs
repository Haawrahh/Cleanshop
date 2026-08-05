using Cleanshop.domain.Entities;
using Cleanshop.domain.Interfaces;
using MediatR;

namespace Cleanshop.Application.Products.Commands;

public class UpdateProductCommandHandler
    : IRequestHandler<UpdateProductCommand, Product>
{
    private readonly IProductRepository _repository;

    public UpdateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Product> Handle(
        UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = request.Id,
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _repository.UpdateAsync(product);
        return product;
    }
}

