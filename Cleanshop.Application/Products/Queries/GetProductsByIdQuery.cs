using Cleanshop.domain.Entities;
using MediatR;

namespace Cleanshop.Application.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product?>;
