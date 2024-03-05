public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;    
        Price = price;
        QuantityInStock = quantityInStock;
        // TODO: Initialize the properties with the values passed to the constructor.
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        // TODO: Update the item's price with the new price.
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        // TODO: Increase the item's stock quantity by the additional quantity.
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold > QuantityInStock)
        {
            Console.WriteLine("Insufficient stock sell the requested quantity");

        }
        else
        {
            QuantityInStock -= quantitySold;
        }
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Quantity in stock:{QuantityInStock}");
        Console.WriteLine();
        // TODO: Print the details of the item (name, id, price, and stock quantity).
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        //Details of all the items
        Console.WriteLine("Initial Inventory");
        item1.PrintDetails();
        item2.PrintDetails();

        //selling some items
        item1.SellItem(4);
        item2.SellItem(8);

        //restocking an item
        item1.RestockItem(4);

        //updated details

        Console.WriteLine("Updated Inventory");
        item1.PrintDetails();
        item2.PrintDetails();

        //checking if the item is in stock
        if (item2.IsInStock())
        {
            Console.WriteLine("intem2 (smartphone) is in stock");

        }
        else
        {
            Console.WriteLine("item2 (smartphone) is out of stock");

        }
    }
}
        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.


    

