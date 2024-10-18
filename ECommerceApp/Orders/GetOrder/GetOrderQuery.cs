using MediatR;

namespace ECommerceApp.Orders.GetOrder;

public record GetOrderQuery(Guid Id) : IRequest<GetOrderResponse>;