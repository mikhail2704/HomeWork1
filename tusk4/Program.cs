 Console.Write("Число с которого начнутся отсчёт: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Последнее число: ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = n; i <= m; i++)
    {
        if (i % 2 == 0) 
        {
            Console.WriteLine("Чётное -> " + i );
        }
    }