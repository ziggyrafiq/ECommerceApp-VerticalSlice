using MediatR;

namespace ECommerceApp.Products.AddProduct;
public record AddProductCommand(string Name, decimal Price, string Description) : IRequest<AddProductResponse>;

