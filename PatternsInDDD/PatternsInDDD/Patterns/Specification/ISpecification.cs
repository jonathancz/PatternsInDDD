namespace PatternsInDDD.Patterns;

public interface ISpecification<T>
{
    bool IsSatisfiedBy(T item);
}