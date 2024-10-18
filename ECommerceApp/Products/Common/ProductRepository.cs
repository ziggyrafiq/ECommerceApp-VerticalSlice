using ECommerceApp.Infrastructure;

namespace ECommerceApp.Products.Common;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task<Product?> GetProductByIdAsync(Guid id) => await _context.Products.FindAsync(id);
}