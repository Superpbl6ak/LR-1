namespace classess;

public abstract class Product
{
    public int Vid {get; set;}
    public string Name {get; set;}
    public double Price {get; set;}
    public string Proiz {get; set;}
    public int Age {get; set;}
    public Product(string name, double price, string proiz, int age)
    {
        Name = name;
        Price = price;
        Proiz = proiz;
        Age = age;
    }
}