int Name(int a, int b)
{
    int prod = a;
    for (int i = 1; i <= b; i++)
    prod*= a;
    return prod;
        
}


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Name(num1, num2));
