using Microsoft.AspNetCore.Routing.Matching;
using PatternsInDDD.Domain.Entities;

namespace PatternsInDDD.Patterns.Specs;

public class FullNameContains : Specification<Employee>
{
    private readonly string _name;

    public FullNameContains(string name)
    {
        _name = name;
    }
    
    public override bool IsSatisfiedBy(Employee item)
    {
        return item.FullName.Contains(_name, StringComparison.OrdinalIgnoreCase);
    }
}