// Может ли существовать треугольник (каждая сторона меньше суммы двух других его сторон)

void TryG()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if (a < b + c & b < a + c & c < a + b)
    Console.WriteLine("Yes");
    else
     Console.WriteLine("No");

}
TryG();