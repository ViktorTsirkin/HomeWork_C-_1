Console.WriteLine("Введи первое число: ");
int x = int.Parse(Console.ReadLine()); //записали введенное число в переменную x
Console.WriteLine("Введи второе число: ");
int y = int.Parse(Console.ReadLine()); //записали введенное число в переменную y
Console.WriteLine("Введи третье число: ");
int z = int.Parse(Console.ReadLine()); //записали введенное число в переменную z
int m = x;
if (x > y)
{
    m = x;
}
else
{
    m = y;
}
if (m > z)
{
    Console.WriteLine($"максимальное число {m}");
}
else
{
    Console.WriteLine($"максимальное число {z}");
}