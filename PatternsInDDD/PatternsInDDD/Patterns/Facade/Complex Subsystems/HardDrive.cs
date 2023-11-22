namespace PatternsInDDD.Patterns.Facade.Complex_Subsystems;

public class HardDrive
{
    public byte[] Read(long lba, int size)
    {
        Console.WriteLine($"Reading {size} bytes from LBA {lba}..."); 
        return new byte[size];
    }
}