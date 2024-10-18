using ECommerceApp.Common;
using ECommerceApp.Orders.Common;
using MediatR;


namespace ECommerceApp.Orders.GetOrder;

public class GetOrderHandler : IRequestHandler<GetOrderQuery, GetOrderResponse>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<GetOrderResponse> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.GetOrderByIdAsync(request.Id);
        if (order == null)
        {
            throw new NotFoundException($"Order with ID {request.Id} not found."); // Or handle it in another way
        }

        return new GetOrderResponse(order.Id, order.CustomerName, order.TotalAmount, order.OrderDate);
    }
}