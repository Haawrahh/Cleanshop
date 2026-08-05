using MediatR;

namespace Cleanshop.Application.Products.Commands;

public record DeleteProductCommand(int Id)  :  IRequest<bool>;
