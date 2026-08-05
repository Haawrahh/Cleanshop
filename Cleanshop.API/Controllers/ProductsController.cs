using Cleanshop.Application.Products.Commands;
using Cleanshop.Application.Products.Queries;
using Cleanshop.domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cleanshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            var createdProduct = await _mediator.Send(
                new CreateProductCommand(
                    product.Name,
                    product.Price,
                    product.CategoryId
                )
            );

            return Ok(createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id, Product product)
        {
            var updatedProduct = await _mediator.Send(
                new UpdateProductCommand(
                    id,
                    product.Name,
                    product.Price,
                    product.CategoryId
                )
            );

            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return NoContent();
        }
    }
}