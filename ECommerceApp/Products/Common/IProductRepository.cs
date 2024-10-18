namespace ECommerceApp.Products.Common;

public interface IProductRepository
{
    Task AddProductAsync(Product product);
    Task<Product?> GetProductByIdAsync(Guid id);
}
