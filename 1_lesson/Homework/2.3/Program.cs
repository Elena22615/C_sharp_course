void Num(int num)
{
    Console.Write($"{num} ");
    if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }

    while(num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

Num(int.Parse(Console.ReadLine()));
