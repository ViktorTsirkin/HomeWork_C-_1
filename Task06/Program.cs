Console.WriteLine("Введи число: ");
int x = int.Parse(Console.ReadLine()); //записали введенное число в переменную x
if (x % 2 == 0)
{
    Console.WriteLine($"Число {x} - четное");
}
else
{
    Console.WriteLine($"Число {x} - нечетное");
}