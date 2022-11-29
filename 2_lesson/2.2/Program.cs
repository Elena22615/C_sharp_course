string ABC(int num1, int num2)
{
if (num1 % num2 == 0)
    return "кратно";
else
    return $"не кратно, остаток = {num1 % num2}";

}

Console.WriteLine("Write number 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write number 2");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(ABC(num1, num2));