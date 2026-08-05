using Cleanshop.domain.Entities;
using Cleanshop.domain.Interfaces;
using MediatR;

namespace Cleanshop.Application.Products.Queries
{
    public class GetProductByIdQueryHandler
        : IRequestHandler<GetProductByIdQuery, Product?>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product?> Handle(
            GetProductByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}