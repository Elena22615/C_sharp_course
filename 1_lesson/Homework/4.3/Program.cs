void Massiv(int[] n)
{
    int array = n.Length;

    for (int i = 0; i < array; i++)
        Console.Write($"{n[i]} ");
        Console.WriteLine();
}

int[] Massiv1(int array)
{
    int[] n = new int[array];
    for (int i = 0; i < array; i++)
        n[i] = new Random().Next(1, 100);
    return n;
}

int[] num1 = Massiv1(int.Parse(Console.ReadLine()));
Massiv(num1);
int[] num2 = Massiv1(int.Parse(Console.ReadLine()));
Massiv(num2);