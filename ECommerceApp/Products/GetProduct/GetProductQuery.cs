using MediatR;

namespace ECommerceApp.Products.GetProduct;

public record GetProductQuery(Guid Id) : IRequest<GetProductResponse>;
