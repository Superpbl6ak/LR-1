namespace classess;

class sport: Product
{
    public sport(string name, double price, string proiz, int age) : base(name, price, proiz, age)
    { Vid = 3; }

    public override string ToString()
    { return "Спорт: "+Name+". Цена: "+ string.Format("{0:F2}",Price)+" руб. Произведено в: "+Proiz+". Можно использовать с "+Age+" лет."; }
}