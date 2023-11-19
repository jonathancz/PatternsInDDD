using Bogus;

namespace PatternsInDDD.Domain.Entities;

public class Customer
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public Customer()
    {
        
    }

    public Customer(string firstName, string lastName, string email, DateTime dateOfBirth, string phoneNumber, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}

public class CustomerFaker : Faker<Customer>
{
    public CustomerFaker()
    {
        RuleFor(c => c.FirstName, f => f.Name.FirstName());
        RuleFor(c => c.LastName, f => f.Name.LastName());
        RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName));
        RuleFor(c => c.DateOfBirth, f => f.Date.Past(100, DateTime.Today.AddYears(-18))); // Ensuring adult customers
        RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());
        RuleFor(c => c.Address, f => f.Address.FullAddress());
    }
}
