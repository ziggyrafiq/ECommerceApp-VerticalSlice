namespace ECommerceApp.Orders.GetOrder;

public record GetOrderResponse(Guid Id, string CustomerName, decimal TotalAmount, DateTime OrderDate);