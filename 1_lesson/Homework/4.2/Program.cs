int SumNums(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}
Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));