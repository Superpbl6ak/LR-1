Write("Введите число: ");
int.TryParse(ReadLine(), out int chislo);
int sch = 0;
int kolvo = 0;

for (int x = 1; x<=(chislo/2); x++)
{
    if (chislo % x == 0)
    {
        sch++;
            
    }
       
}
WriteLine(sch==1 ? "Это число простое." : "Это число не простое.");

sch = 0;

Write("Список простых чисел от 0 до вашего числа:");
for (int i = 1; i < chislo; i++)
{
    for (int x = 1; x<=(i/2); x++)
    {
        if (i % x == 0)
        {
            sch++;
            
        }
       
    }
    if (sch==1)
    {
        kolvo++;
           Write(" "+i);
    }
    sch = 0;
}

if (kolvo == 0)
{
    Write(" отсутствуют");
    
}

WriteLine();
WriteLine("Для завершения нажмите любую клавишу...");
ReadKey();
    
    