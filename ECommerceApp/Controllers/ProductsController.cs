using ECommerceApp.Products.AddProduct;
using ECommerceApp.Products.GetProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var query = new GetProductQuery(id);  
        var product = await _mediator.Send(query);

        if (product == null)
        {
            return NotFound($"Product with ID {id} not found.");
        }

        return Ok(product);
    }

    
    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] AddProductCommand command)
    {
        if (command == null)
        {
            return BadRequest("Invalid product details.");
        }

        var result = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetProductById), new { id = result.ProductId }, result);
    }
}
