using Bogus;

namespace PatternsInDDD.Domain.Entities;

public class Employee
{
    public string EmployeeId { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }
    public string Department { get; set; }

    public Employee()
    {
        
    }

    public Employee(string employeeId, string fullName, string position, DateTime hireDate, string department)
    {
        EmployeeId = employeeId;
        FullName = fullName;
        Position = position;
        HireDate = hireDate;
        Department = department;
    }
}

public class EmployeeFaker : Faker<Employee>
{
    public EmployeeFaker()
    {
        RuleFor(e => e.EmployeeId, f => f.Random.Guid().ToString());
        RuleFor(e => e.FullName, f => f.Name.FullName());
        RuleFor(e => e.Position, f => f.Name.JobTitle());
        RuleFor(e => e.HireDate, f => f.Date.Past(10));
        RuleFor(e => e.Department, f => f.Commerce.Department());
    }
}
