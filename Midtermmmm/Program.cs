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
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold > QuantityInStock)
        {
            Console.WriteLine("Insufficient stock to sell the requested quantity.");
        }
        else
        {
            QuantityInStock -= quantitySold;
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        Console.WriteLine("**Initial Inventory**");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items
        item1.SellItem(4);
        item2.SellItem(8);

        // Restock an item
        item1.RestockItem(5);

        // Print updated details
        Console.WriteLine("**Updated Inventory**");
        item1.PrintDetails();
        item2.PrintDetails();

        // Check if an item is in stock
        if (item2.IsInStock())
        {
            Console.WriteLine("item2 (Smartphone) is in stock.");
        }
        else
        {
            Console.WriteLine("item2 (Smartphone) is out of stock.");
        }
    }
}
