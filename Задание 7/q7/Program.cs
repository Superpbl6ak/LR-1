global using static System.Console;
using static Microsoft.VisualBasic.VBMath;
using classess;


Product[] spisok =
{
    new toy("Кукла", 1999, "Россия", "Пластик", 6),
    new toy("Юла", 299, "Россия", "Пластик", 3),
    new book("Война и мир", "Ф. М. Достоевский", 1499, "Русская классика", 16),
    new book("METRO 2033", "Д. А. Глуховский", 916, "Россия", 16),
    new sport("Мяч Футбольный Adidas", 3000, "Пакистан", 6),
    new sport("Кроссовки Puma", 2300, "Вьетнам", 0),
};


while (true)
{
    WriteLine("Каталог нашего магазина");
    WriteLine("Введите что вы хотите найти:");
    WriteLine("1 - Детские товары");
    WriteLine("2 - Книги");
    WriteLine("3 - Спорт");
    WriteLine("4 - Вывести весь ассортимент");
    WriteLine("0 - Выход с сайта");
    Write("Введите номер раздела: ");
    string choise = ReadLine();
    WriteLine();
    if (choise == "0") break;
    
    if (choise == "1")
    {
        WriteLine("Раздел: Детские товары");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 1)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "2")
    {
        WriteLine("Раздел: Книги");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 2)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "3")
    {
        WriteLine("Раздел: Спорт");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            if (product.Vid == 3)
                Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
    else if (choise == "4")
    {
        WriteLine("Весь ассортимент");
        for (var i = 0; i < spisok.Length; i++)
        {
            var product = spisok[i];
            Console.WriteLine(product.ToString());
        }

        WriteLine();
    }
}
