using Cleanshop.domain.Interfaces;
using MediatR;

namespace Cleanshop.Application.Products.Commands;

public class DeleteProductCommandHandler
    : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IProductRepository _repository;

    public DeleteProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        return await _repository.DeleteAsync(request.Id);
    }
}