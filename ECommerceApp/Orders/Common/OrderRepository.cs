using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Orders.Common;
public class OrderRepository : IOrderRepository
{
    private readonly DbContext _context;

    public OrderRepository(DbContext context)
    {
        _context = context;
    }

    public async Task AddOrderAsync(Order order)
    {
        await _context.Set<Order>().AddAsync(order);
        await _context.SaveChangesAsync();
    }

    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
        return await _context.Set<Order>().FindAsync(id);
    }
}