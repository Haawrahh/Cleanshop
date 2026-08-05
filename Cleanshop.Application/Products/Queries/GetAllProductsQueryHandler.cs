using Cleanshop.domain.Entities;
using Cleanshop.domain.Interfaces;
using MediatR;

namespace Cleanshop.Application.Products.Queries;

public class GetAllProductsQueryHandler
    : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Product>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
