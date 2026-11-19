using System;

public class Product
{
    // Declared Fields
    private string code;
    private string name;
    private double price;
    private int quantity;

    // Properties
    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                throw new ArgumentException("Product name cannot be empty.");
        }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                throw new ArgumentException("Price must be greater than zero.");
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0)
                quantity = value;
            else
                throw new ArgumentException("Quantity cannot be negative.");
        }
    }

    // Read properties
    public double TotalValue
    {
        get { return Price * Quantity; }
    }

    // Constructor Variables
    public Product(string code, string name, double price, int quantity)
    {
        Code = code;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Display of Information
    public void DisplayInfo()
    {
        Console.WriteLine("Product Code: " + Code);
        Console.WriteLine("Product Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total Value: " + TotalValue);
        Console.WriteLine("-------------------------");
    }
}