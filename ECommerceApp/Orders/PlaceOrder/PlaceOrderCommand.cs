using MediatR;

namespace ECommerceApp.Orders.PlaceOrder;

public record PlaceOrderCommand(string CustomerName, decimal TotalAmount) : IRequest<PlaceOrderResponse>;