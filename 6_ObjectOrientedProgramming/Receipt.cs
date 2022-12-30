
public class Receipt
{
    // Receipt data
    private List<Item> items;
    private double totalPrice;

    // Constructor
    public Receipt()
    {
        items = new List<Item>();
        totalPrice = 0;
    }

    // Add an item to the receipt
    public void AddItem(string name, double price)
    {
        var item = new Item(name, price);
        items.Add(item);
        totalPrice += price;
    }

    // Subtract item from the receipt
    public void SubtractItem(string name, double price)
    {
        var item = new Item(name, price);
        items.Add(item);
        totalPrice -= price;
    }

    // Print the receipt
    public void Print()
    {
        Console.WriteLine("Items: ");
        foreach (var item in items)
        {
            Console.WriteLine(item.name + " - kr " + item.price);
        }
        Console.WriteLine("Total: kr " + totalPrice);
    }

    // Item class
    private class Item
    {
        public string name;
        public double price;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
