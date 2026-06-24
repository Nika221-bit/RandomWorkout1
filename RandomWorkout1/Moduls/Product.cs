namespace RandomWorkout1.Moduls;

public class Product
{
   

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    
    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void Print()
    {
        Console.WriteLine($"saxeli : {Name}");
        Console.WriteLine($"fasi : {Price}");
        Console.WriteLine($"raodenoba : {Quantity}");
    }
    
    public static Product GetTotalValue()
    {
        Console.WriteLine("sheiyvanet saxeli");
        string name = Console.ReadLine();
        Console.WriteLine("sheiyvanet fasi");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("sheiyvanet raodenoba");
        int quantity = int.Parse(Console.ReadLine());
        
        
        
        Product  newProduct = new Product(name, price, quantity);
        
       decimal totalValue = price * quantity;
        Console.WriteLine(totalValue);
        
        return newProduct;

    }
}

 