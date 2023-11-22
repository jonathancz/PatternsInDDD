using Xunit;

namespace PatternsInDDD.Patterns.Anti_Corruption_Layer;

/// <summary>
/// See: Facade Pattern
/// ACL acting as a Facade to shield the modern system from the legacy system's
/// complexities.
///
/// Explanation:
/// - The LegacyInventorySystem represents the complex, outdated system.
/// - The InventoryAdapter acts as an adapter, converting the legacy system's
/// complex response into a format understandable by the modern system.
/// - The InventoryFacade serves as the ACL, providing simple and clean interface to
/// the modern e-commerce application. It uses the adapter to communicate with the
/// legacy system.
///
/// This example demonstrates how the ACL, using Adapter and Facade patterns,
/// effectively separates the concerns between a modern system and a legacy or
/// external system, ensuring the maintainability and integrity of the domain models
/// and system's architecture.
/// </summary>
public class InventoryAclFacade
{
    private readonly InventoryAdapter _inventoryAdapter;

    public InventoryAclFacade(InventoryAdapter inventoryAdapter)
    {
        _inventoryAdapter = inventoryAdapter;
    }

    public bool CheckProductAvailability(string productId)
    {
        return _inventoryAdapter.IsProductAvailable(productId);
    }
}