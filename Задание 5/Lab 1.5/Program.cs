Write("Введите число месяца: ");
int.TryParse(ReadLine(), out int mes);
if (mes>=1 && mes <=12)
{
    switch (mes)
    {
        case 12: WriteLine("Это зима");
            break;
        case >=9:
            WriteLine("Это осень");
            break;
        case >=6:
            WriteLine("Это лето");
            break;
        case >=3:
            WriteLine("Это весна");
            break;
        case >=1:
            WriteLine("Это зима");
            break;
    }

}
else{WriteLine("Такого месяца нет");}