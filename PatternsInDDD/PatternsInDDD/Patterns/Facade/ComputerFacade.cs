using PatternsInDDD.Patterns.Facade.Complex_Subsystems;
using Xunit;

namespace PatternsInDDD.Patterns.Facade;

/// <summary>
/// The Facade Pattern is a structural pattern that provides a simplified interface
/// interface to a complex system of classes, a library, or a framework.
/// It's often used when working with a complex set of interfaces, and there
/// is a need to provide a simple, unified interface for the end users or client
/// code.
///
/// In this example, let's imagine we have a computer system with several
/// components like a CPU, Memory, and Hard Drive. Each of these components has its
/// own methods and complexities. We will use the Facade Pattern to provide a simplified
/// interface to start the computer.
/// </summary>
public class ComputerFacade
{
    private readonly CPU _cpu;
    private readonly Memory _memory;
    private readonly HardDrive _hardDrive;
    
    // Example OS constants
    private const long BOOT_ADDRESS = 0x0000;
    private const long BOOT_SECTOR = 0x0000;
    private const int SECTOR_SIZE = 1024;

    public ComputerFacade()
    {
        _cpu = new CPU();
        _memory = new Memory();
        _hardDrive = new HardDrive();
    }

    public void Start()
    {
        _cpu.TimeOut();
        _memory.Load(BOOT_ADDRESS, _hardDrive.Read(BOOT_SECTOR, SECTOR_SIZE));
        _cpu.Jump(BOOT_ADDRESS);
        _cpu.Execute();
    }
    
    // Usage 
    [Fact]
    public void CanUseComputerFacade()
    {
        ComputerFacade computer = new ComputerFacade();
        computer.Start();
    }
}