int Degree(int a, int b)
{
    if (b == a) return 1;
    return Degree(a, b - 1) + b;
}
Console.WriteLine(Degree(1, 15));