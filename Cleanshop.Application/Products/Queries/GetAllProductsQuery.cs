using Cleanshop.domain.Entities;
using MediatR;

namespace Cleanshop.Application.Products.Queries;
public record GetAllProductsQuery : IRequest<List<Product>>;
