int Sum(int a)
{
    if (a == 0) return 0;
    return Sum(a / 10) + a % 10;
}
Console.WriteLine(Sum(453));