using ECommerceApp.Orders.Common;
using MediatR;

namespace ECommerceApp.Orders.PlaceOrder;

public class PlaceOrderHandler : IRequestHandler<PlaceOrderCommand, PlaceOrderResponse>
{
    private readonly IOrderRepository _orderRepository;

    public PlaceOrderHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<PlaceOrderResponse> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),  
            CustomerName = request.CustomerName,
            TotalAmount = request.TotalAmount,
            OrderDate = DateTime.UtcNow  
        };

        await _orderRepository.AddOrderAsync(order);

        return new PlaceOrderResponse(order.Id, order.CustomerName);
    }
}