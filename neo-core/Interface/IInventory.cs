namespace Neo.Interface
{ 
    /// <summary>
    /// Represents a message that can be relayed on the NEO network.
    /// </summary>
public interface IInventory : IVerifiable
    {
        /// <summary>
        /// The type of the inventory.
        /// </summary>
        InventoryType InventoryType { get; }
    }
}
