Write("Введите число A типа double: ");
double.TryParse(ReadLine(), out double A);

Write("Введите число B типа double: ");
double.TryParse(ReadLine(), out double B);

WriteLine();
WriteLine($"Ваши числа: A={A}, B={B}");
WriteLine();
WriteLine("Произходит подмена...");
(A, B) = (B, A);
WriteLine($"Ваши числа: A={A}, B={B}");
WriteLine("Для продолжения нажмите любую кнопку...");
ReadKey();

