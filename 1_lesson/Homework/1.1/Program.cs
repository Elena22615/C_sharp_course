Console.WriteLine("write number1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("write number2");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("number 1 - большее, number 2 - меньшее");
}

else if (num2 > num1)
{
    Console.WriteLine("number 2 - большее, number 1 - меньшее");
}

else
{
    Console.WriteLine("числа равны");
}