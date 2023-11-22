namespace PatternsInDDD.Patterns.Anti_Corruption_Layer;

/// <summary>
/// See: Adapter Pattern
/// Adapter to translate the modern system's request into the legacy
/// system's format 
/// </summary>
public class InventoryAdapter
{
    private readonly LegacyInventorySystem _legacyInventorySystem;

    public InventoryAdapter()
    {
        // Use Dependency Injection instead of instantiating it like this.
        _legacyInventorySystem = new LegacyInventorySystem();
    }

    public bool IsProductAvailable(string productId)
    {
        string availabilityData = _legacyInventorySystem.CheckAvailability(productId);
        // Validate complex data then return boolean
        return true;
    }
}