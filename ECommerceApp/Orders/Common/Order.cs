namespace ECommerceApp.Orders.Common;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string CustomerName { get; set; }=string.Empty;
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }

   
}