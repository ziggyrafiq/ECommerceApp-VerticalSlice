# A Detailed Guide to Vertical Slice Architecture with Code Examples in C# 12 (ECommerceApp-VerticalSlice)
Using C# 12's vertical slice architecture, Ziggy Rafiq demonstrates how to improve modularity and scalability by focusing on feature-based organization. This guide demonstrates how to write maintainable, testable applications by structuring code around features. It demonstrates how to create command handlers, repositories, and handlers using C# 12's record types and MediatR.

**[Article published on C# Corner click here to read this article](https://www.c-sharpcorner.com/article/a-detailed-guide-to-vertical-slice-architecture-with-code-examples-in-c-sharp-12/ )**

### Getting Started
Clone this repository to your local machine to get started using the resources:

 ```bash
git clone https://github.com/ziggyrafiq/ECommerceApp-VerticalSlice.git`
```

Explore the contents, refer to the guidelines, and use the examples to improve your C# programming skills!



## Project Structure
The example of this article project structure is as following below.
ECommerceApp
│
├── src
├── Common
│   │   ├── NotFoundException.cs
├── Controllers
│   │   ├── OrdersController.cs
│   │   ├── ProductsController.cs
├── Infrastructure
│   │   ├── AppDbContext.cs
│   ├── Products
│   │   ├── AddProduct
│   │   │   ├── AddProductCommand.cs
│   │   │   ├── AddProductHandler.cs
│   │   │   ├── AddProductResponse.cs
│   │   ├── GetProduct
│   │   │   ├── GetProductQuery.cs
│   │   │   ├── GetProductHandler.cs
│   │   │   ├── GetProductResponse.cs
│   │   ├── Common
│   │   │   ├── IProductRepository.cs
│   │   │   ├── ProductRepository.cs
│   │   │   └── Product.cs                
│   ├── Orders
│   │   ├── GetOrder
│   │   │   ├── GetOrderCommand.cs
│   │   │   ├── GetOrderHandler.cs
│   │   │   ├── GetOrderResponse.cs
│   │   ├── PlaceOrder
│   │   │   ├── PlaceOrderCommand.cs
│   │   │   ├── PlaceOrderHandler.cs
│   │   │   ├── PlaceOrderResponse.cs
│   │   ├── Common
│   │   │   ├── IOrderRepository.cs
│   │   │   ├── OrderRepository.cs
│   │   │   └── Order.cs                  
│   ├── Controllers
│   │   ├── ProductsController.cs
│   │   └── OrdersController.cs
│   └── ECommerceApp.csproj
└── Program.cs

## About The Author Ziggy Rafiq

Ziggy Rafiq works as a Technical Lead Developer and is a prominent public figure in the tech industry and developer community. With over 20 years of experience as a Full-Stack Designer, Developer, Tester, DevSecOps, Technical Architect,
Software Project Manager, and expert in Agile Management Best Practices and Standards, Ziggy is widely respected for his knowledge and skills. He is also an author, regularly contributing articles
to [C# Corner](https://www.c-sharpcorner.com/members/ziggy-rafiq), and [Geek Coding](https://geek-coding.com/members/ziggy-rafiq) to
share his expertise and wisdom with a global audience. Ziggy also has a YouTube Channel where he creates content based on his experience to help and inspire other developers, designers, testers, project managers,
technical architects, and Agile Scrum masters.

- **Technical Lead Developer, Mentor and Trainer**
- **[C# Corner (MVP 🏅, VIP⭐️, Public Speaker🎤)](https://www.c-sharpcorner.com/members/ziggy-rafiq)**
- **[Geek Coding Writter](https://geek-coding.com/members/ziggy-rafiq)**
- **[Technology Manager Writter](https://technology-manager.com/members/ziggy-rafiq)**
- Link to [**Ziggy Rafiq Blog**](https://blog.ziggyrafiq.com)
- Link to [**Ziggy Rafiq Website**](https://ziggyrafiq.com)

* [**Please remember to subscribe to My YouTube channel**](https://www.youtube.com/)
* [**Please remember to follow me on LinkedIn**](https://www.linkedin.com/in/ziggyrafiq/)
* [**Please remember to follow me on Twitter/X**](https://twitter.com/ziggyrafiq)
* [**Please remember to follow me on Instagram**](https://www.instagram.com/ziggyrafiq/)
* [**Please remember to follow me on Facebook**](https://www.facebook.com/ziggyrafiq)

## Contributing

Any improvements or corrections should be submitted as a pull request or opened in an issue.

## License

The LICENSE file contains details about how this project is licensed under the MIT License.
