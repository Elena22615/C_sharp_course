void Equation(double k1, double k2, double b1, double b2)
{
    double a = k1 - k2;
    if (a != 0)
    {
        double x = (b2 - b1) / (a);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка: ({x}; {y}");
    }
}

Equation(int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()));