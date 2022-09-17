Console.WriteLine("Введи число: ");
int n = int.Parse(Console.ReadLine()); //записали введенное число в переменную n
int a = 1;
while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.Write(a+";");
        a++;
    }
    else
    {
        Console.Write(" ");
        a++;
    }
}