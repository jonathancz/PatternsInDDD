using PatternsInDDD.Domain.Entities;
using PatternsInDDD.Patterns.Specs;
using Xunit;

namespace PatternsInDDD.Patterns;

/// <summary>
/// 
/// </summary>
public class SpecificationPatternExample
{
    private readonly List<Employee> _listOfEmployees = new EmployeeFaker().Generate(500);
    private readonly List<Customer> _listOfCustomers = new CustomerFaker().Generate(500);

    [Fact]
    public void CanGetProductsThatContainName()
    {
        var employeeJobTitleSpec = new HasJobTitle("Engineer");
        var employeeFullNameSpec = new FullNameContains("John");
        
        // Using one specification
        var engineers = _listOfEmployees.Where(employee => employeeJobTitleSpec.IsSatisfiedBy(employee));
        var johns = _listOfEmployees.Where(employee => employeeFullNameSpec.IsSatisfiedBy(employee));

        
        Assert.NotEmpty(engineers);
        Assert.NotEmpty(johns);
        
        // We can use the Composite class to create more advance queries by chaining different specifications
        var andSpec = new HasJobTitle("Engineer").And(new FullNameContains("Ed"));
        var engineersNamedJohn = _listOfEmployees.Where(employee => andSpec.IsSatisfiedBy(employee));
    }
}