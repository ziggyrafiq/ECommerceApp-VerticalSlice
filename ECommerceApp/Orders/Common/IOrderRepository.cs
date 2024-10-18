namespace ECommerceApp.Orders.Common;

public interface IOrderRepository
{
    Task AddOrderAsync(Order order);
    Task<Order?> GetOrderByIdAsync(Guid id);
}