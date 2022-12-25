namespace classess;

class book : Product
{
    public string Author;
    public book(string name, string author, double price, string proiz, int age) : base(name, price, proiz, age)
    { Vid = 2; Author = author; }
    
    public override string ToString()
    { return "Книга: "+Name+". Автор: "+Author+". Цена: "+ string.Format("{0:F2}",Price)+" руб. Издательство: "+Proiz+". Доступно к чтению с "+Age+" лет."; }
}