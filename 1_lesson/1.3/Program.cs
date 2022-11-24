Console.WriteLine("Write number");
string a = Console.ReadLine();
int N = int.Parse(a);
int M = -N;

while(M<=N) 
{
    Console.Write($"{M} ");
    M+=1;
}

