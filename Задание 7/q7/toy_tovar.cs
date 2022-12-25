namespace classess;

class toy : Product
{
    public string Mat;
    public toy(string name, double price, string proiz, string mat, int age) : base(name, price, proiz, age)
    { Mat = mat; Vid = 1; }

    public override string ToString()
    {
       
        return "Детские товары: "+Name+". Цена: "+ string.Format("{0:F2}",Price)+" руб. Произведено в: "+Proiz+". Материал: "+Mat+". Можно использовать с "+Age+" лет.";
    }
}