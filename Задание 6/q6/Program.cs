global using static System.Console;


Person[] students = new Person [0];
int per = 0;

while (true)
{   
    WriteLine("Доступные варианты действий:");
    WriteLine("1 - Вывод всех студентов");
    WriteLine("2 - Вывод только отличников");
    WriteLine("3 - Вывод студудентов с двойкой");
    WriteLine("4 - Ввод новых студентов");
    WriteLine("0 - Выход из программы");
    WriteLine();
    Write("Выбор варианта: ");
    string? action = ReadLine();
    WriteLine();
    if (action == "0") break;
    int num = 0;
    switch (action)
    {
        case "1":
            WriteLine("1 - Вывод всех студентов");
            if (per == 0)
            {
                WriteLine("Студенты не введены");
                WriteLine();
                break;
            }
            num = 1;
            foreach (var i in students)
            {
                Write($"Студент №{num} ");
                i.Print();
                num++;
            }
            WriteLine();
            break;

        
        case "2":
            WriteLine("2 - Вывод отличников");
            int counternum = 0;
            int kol = 0;
            for (int i = 0; i < students.Length; i++)
            {
                Person id = students[i];
                for (var ip = 0; ip < students[i].success.Length; ip++)
                {
                    int index = id.success[ip];
                    if (index == 5)
                    {
                        kol++;
                    }
                    if (kol==id.success.Length)
                    {
                        WriteLine($"Студент {students[i].Name}");
                        counternum++;
                    }
                }
            }
            if (counternum == 0)
            {
                WriteLine("Студентов отличников нет");
            }
            WriteLine();
            break;


        case "3":
            WriteLine("3 - Вывод студудентов с хотя ьы одной 2ой");
            kol = 0;
            for (int i = 0; i < students.Length; i++)
            {
                Person id  = students[i];
                for (var ip = 0; ip < students[i].success.Length; ip++)
                {
                    int index = id.success[ip];
                    if (index == 2)
                    {
                        WriteLine($"Студент {students[i].Name}");
                        kol++;
                        break;
                    }
                }
                
            }
            if (kol == 0)
            {
                WriteLine($"Студентов с низкой успеваимостью нет");
            }
            WriteLine();
            break;

        case "4":
            WriteLine("4 - Ввод новых студентов");
            WriteLine("Для остановки введите 0");
            NewStudent();
            WriteLine();
            break;
   
        default:
            WriteLine("неверный ввод");
            break;

    }

}

void NewSuccess(int Student_num)
{
    int num;
    do
    {
        Write("Оценка: ");
        int.TryParse(ReadLine(), out num);
        if (num >= 2 && num <= 5)
        {
            Array.Resize(ref students[Student_num].success, students[Student_num].success.Length + 1);
            students[Student_num].success[students[Student_num].success.Length-1] = num;
        }
    } while (num != 0);   
}

void NewStudent()
{
    per++;
    if (students.Length <= 10)
    {
        Array.Resize(ref students, students.Length + 1);
        Write("Введите ФИО студента: ");
        students[students.Length - 1].Name = ReadLine();
        students[students.Length - 1].success = new int[0];
        NewSuccess(students.Length -1 );
    }
    else
    {
        WriteLine("Достигнут максимум студентов - 10 человек.");
        WriteLine();
    }
}

struct Person
{
    public string? Name;
    public int[] success;
    public void Print()
    {
        Write($"ФИО: {Name}. ");
        if (success.Length != 0)
        {
            Write("Оценки: ");
            for (var index = 0; index < success.Length; index++)
            {
                var i = success[index];
                Write(i + " ");
            }
        }
        else
        {
            Write("Оценок нет.");
        }

        WriteLine();
    }
}
    





