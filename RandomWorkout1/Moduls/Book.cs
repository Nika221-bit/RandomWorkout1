namespace RandomWorkout1.Moduls;

public class Book :Product
{
  
    
    public string Author { get; set; }
    
    public Book(string name,decimal price,int quantity,string author):base(name,price,quantity)
    {
        Author = author;
    }

    
}

