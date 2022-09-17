Console.WriteLine("Введи первое число: ");
int x = int.Parse(Console.ReadLine()); //записали введенное число в переменную x
Console.WriteLine("Введи второе число: ");
int y = int.Parse(Console.ReadLine()); //записали введенное число в переменную y
if (x > y)
{
    Console.WriteLine($"Число {x} больше числа {y}");
}
else
{
    Console.WriteLine($"Число {y} больше числа {x}");
}