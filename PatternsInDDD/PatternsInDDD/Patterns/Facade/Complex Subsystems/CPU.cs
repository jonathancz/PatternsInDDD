namespace PatternsInDDD.Patterns.Facade.Complex_Subsystems;

public class CPU
{
    public void TimeOut()
    {
        Console.WriteLine("CPU time out...");
    }

    public void Jump(long position)
    {
        Console.WriteLine($"Jumping to position {position}...");
    }

    public void Execute()
    {
        Console.WriteLine("CPU executing commands...");
    }
}