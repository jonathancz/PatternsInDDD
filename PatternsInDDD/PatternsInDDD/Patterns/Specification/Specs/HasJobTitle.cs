using PatternsInDDD.Domain.Entities;

namespace PatternsInDDD.Patterns.Specs;

public class HasJobTitle : Specification<Employee>
{
    private readonly string _jobTitle;

    public HasJobTitle(string jobTitle)
    {
        _jobTitle = jobTitle;
    }


    public override bool IsSatisfiedBy(Employee item)
    {
        return item.Position.Contains(_jobTitle, StringComparison.OrdinalIgnoreCase);
    }
}