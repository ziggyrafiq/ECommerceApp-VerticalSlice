using ECommerceApp.Orders.GetOrder;
using ECommerceApp.Orders.PlaceOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

  
    [HttpPost]
    public async Task<IActionResult> PlaceOrder([FromBody] PlaceOrderCommand command)
    {
        if (command == null)
        {
            return BadRequest("Invalid order details.");
        }

        var result = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetOrderById), new { id = result.OrderId }, result);
    }

 
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetOrderById(Guid id)
    {
        var query = new GetOrderQuery(id);
        var order = await _mediator.Send(query);

        if (order == null)
        {
            return NotFound($"Order with ID {id} not found.");
        }

        return Ok(order);
    }
}