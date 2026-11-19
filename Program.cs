using System;

class Techinv
{
    // Section that asks you to enter information about the product
    static Product CreateProduct()
    {
        string code, name;
        double price;
        int quantity;

        Console.Write("Enter product code: ");
        code = Console.ReadLine() ?? "";

        Console.Write("Enter product name: ");
        name = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Error: Product name cannot be empty.");
            Console.Write("Enter product name: ");
            name = Console.ReadLine() ?? "";
        }

        while (true)
        {
            Console.Write("Enter product price: ");

            if (double.TryParse(Console.ReadLine(), out price)
                && price > 0)
                break;

            Console.WriteLine("Error: Price must be greater than zero.");
        }

        while (true)
        {
            Console.Write("Enter product quantity: ");

            if (int.TryParse(Console.ReadLine(), out quantity)
                && quantity >= 0)
                break;

            Console.WriteLine("Error: Quantity cannot be negative.");
        }

        return new Product(code, name, price, quantity);
    }
    // Display of the inventory system
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("       TECHINV INVENTORY");
        Console.WriteLine("================================");

        Console.WriteLine("\nEnter the first product:");
        Product product1 = CreateProduct();

        Console.WriteLine("\nEnter the second product:");
        Product product2 = CreateProduct();

        Console.WriteLine("\nEnter the third product:");
        Product product3 = CreateProduct();

        Console.WriteLine("\n================================");
        Console.WriteLine("       INVENTORY REPORT");
        Console.WriteLine("================================");

        product1.DisplayInfo();
        product2.DisplayInfo();
        product3.DisplayInfo();

        Console.WriteLine("Inventory report completed.");
    }
}