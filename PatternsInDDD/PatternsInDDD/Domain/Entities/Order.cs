using Bogus;

namespace PatternsInDDD.Domain.Entities;

public class Order
{
    public Guid OrderId { get; set; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; }
    public string CustomerId { get; set; }
    public decimal TotalAmount { get; set; }

    public Order()
    {
        
    }


    public Order(DateTime orderDate, string customerId, decimal totalAmount)
    {
        OrderDate = orderDate;
        CustomerId = customerId;
        TotalAmount = totalAmount;
    }
}

public class OrderFaker : Faker<Order>
{
    public OrderFaker()
    {
        RuleFor(o => o.OrderDate, f => f.Date.Recent(30));
        RuleFor(o => o.CustomerId, f => f.Random.Guid().ToString());
        RuleFor(o => o.TotalAmount, f => f.Finance.Amount(50, 5000));
    }
}

