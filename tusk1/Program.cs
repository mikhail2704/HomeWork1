// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        int max = a;
        Console.WriteLine($"{max}");
    }
    else
    {
        int max = c;
        Console.WriteLine($"{max}");
    }
}
else
{
    if (b > c)
    {
    int max = b;
    Console.WriteLine($"{max}");
    }
    else
    {
    int max = c;
    Console.WriteLine($"{max}");
    }
}
