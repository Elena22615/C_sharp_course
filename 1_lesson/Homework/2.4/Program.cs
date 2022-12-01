void Num(int num)
{
    string A = "no";

    if (num == 6 || num == 7) A = "yes";
    Console.WriteLine($"{num} -> {A}");
}


Num(int.Parse(Console.ReadLine()));