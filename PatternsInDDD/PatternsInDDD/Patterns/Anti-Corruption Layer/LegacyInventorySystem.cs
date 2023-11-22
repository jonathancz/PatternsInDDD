namespace PatternsInDDD.Patterns.Anti_Corruption_Layer;

/// <summary>
/// This represents the old inventory system with a complex and outed interface. 
/// </summary>
public class LegacyInventorySystem
{
    public string CheckAvailability(string productId)
    {
        // Actual business logic here...
        return "Some complex availability data.";
    }
    
    // Other complex legacy methods...
}