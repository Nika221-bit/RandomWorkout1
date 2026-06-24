using RandomWorkout1.Moduls;

//Product
Product newProduct = Product.GetTotalValue();
newProduct.Print();


Book newBook = new Book("Harry Potter", 20m, 3, "J.K. Rowling");
Console.WriteLine(newBook.Discount());
newBook.Print();