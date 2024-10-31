// See https://aka.ms/new-console-template for more information


using _07.Ders_OOP_Encapsulation_;

Book book1 = new Book();
book1.writerName = null;
book1.BookName = "Iblis";
book1.Price = 30;
book1.GetInfo();







/*
Product product1 = new Product("Bread", "Food", 1, 2);
product1.info();

public class Product
{
    public string ProductId { get; set; } = Guid.NewGuid().ToString();
    public string _ProductName;

    public int _Price { get; private set; }

    private string _CategoryName;

    public int _countOfStock;
    public bool inStock;
    public bool InStock
    {
        get { return inStock; }
        private set
        {
            if (_countOfStock > 0)
            {
                inStock = true;
            }
            else
            {
                inStock = false;
            }
        }
    }

    public Product(string name, string categoryName, int Price, int CountOfStock)
    {
        _ProductName=name;
        _CategoryName= categoryName;
        _Price= Price;
        _countOfStock= CountOfStock;

    }

    public void info()
    {
        Console.WriteLine($"Product Id: {ProductId}");
        Console.WriteLine($"Product Name: {_ProductName}");
        Console.WriteLine($"Product Price: {_Price}");
        Console.WriteLine($"Product Stock: {inStock}");
    }
}
*/










