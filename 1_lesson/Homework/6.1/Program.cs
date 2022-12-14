int Num(int n)
{
    int size = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i} ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) size = size + 1;
    }
    return size;
}

Console.Write("Ввод чисел  ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Чисел больше нуля: {Num(a)}");
