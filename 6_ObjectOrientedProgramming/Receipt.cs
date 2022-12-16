
public class Receipt
{
    // Receipt data
    private List<Item> items;
    private double totalPrice;
    private DateTime date;

    // Constructor
    public Receipt()
    {
        items = new List<Item>();
        totalPrice = 0;
        date = DateTime.Now;
    }

    // Add an item to the receipt
    public void AddItem(string name, double price)
    {
        var item = new Item(name, price);
        items.Add(item);
        totalPrice += price;
    }

    // Print the receipt
    public void Print()
    {
        Console.WriteLine("Date: " + date.ToString());
        Console.WriteLine("Items: ");
        foreach (var item in items)
        {
            Console.WriteLine(item.name + " - $" + item.price);
        }
        Console.WriteLine("Total: $" + totalPrice);
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
