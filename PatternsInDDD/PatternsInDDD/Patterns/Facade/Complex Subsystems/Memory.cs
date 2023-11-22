namespace PatternsInDDD.Patterns.Facade.Complex_Subsystems;

public class Memory
{
    public void Load(long position, byte[] data)
    {
        Console.WriteLine($"Loading data into memory at position {position}...");
    }
}