using Bogus;

namespace PatternsInDDD.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string Sku { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public DateTime ManufactureDate { get; set; }

    public Product()
    {
        
    }

    public Product(string productName, string description, string sku, decimal price, string category, DateTime manufactureDate)
    {
        ProductName = productName;
        Description = description;
        Sku = sku;
        Price = price;
        Category = category;
        ManufactureDate = manufactureDate;
    }
}

public class ProductFaker : Faker<Product>
{
    public ProductFaker()
    {
        RuleFor(t => t.ProductName, f => f.Commerce.ProductName());
        RuleFor(a => a.Description, f => f.Commerce.ProductDescription());
        RuleFor(a => a.Sku, f => f.Commerce.Ean13());
        RuleFor(a => a.Price, f => f.Finance.Amount(10, 1000));
        RuleFor(a => a.Category, f => f.Commerce.Categories(1).First());
        RuleFor(a => a.ManufactureDate, f => f.Date.Past(5));
    }
}