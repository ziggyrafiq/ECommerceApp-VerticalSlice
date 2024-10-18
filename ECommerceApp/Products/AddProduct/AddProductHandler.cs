using ECommerceApp.Products.Common;
using MediatR;
namespace ECommerceApp.Products.AddProduct;

public class AddProductHandler : IRequestHandler<AddProductCommand, AddProductResponse>
{
    private readonly IProductRepository _productRepository;

    public AddProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<AddProductResponse> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            Description = request.Description
        };

        await _productRepository.AddProductAsync(product);

        return new AddProductResponse(product.Id, product.Name);
    }
}