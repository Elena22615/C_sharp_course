Console.WriteLine("Write a number");
int num = int.Parse(Console.ReadLine());

string ABC(int num)
{
if (num % 7 == 0 && num % 23 == 0)
    return "divisible";
else
    return "not divisible";

}
Console.WriteLine(ABC(num));

