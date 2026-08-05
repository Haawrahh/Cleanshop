using Cleanshop.domain.Entities;
using MediatR;


namespace Cleanshop.Application.Products.Commands
{
    public record UpdateProductCommand(
   int Id,
   string Name,
   decimal Price,
   int CategoryId
    ) : IRequest<Product>;
}


