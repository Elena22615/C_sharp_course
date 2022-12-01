string Num(int N)

{
    Console.WriteLine(N);
    {
    if(N < 10000 || N > 100000)
    return "Error";
    else if(N %10 == N /10 && N %100 == N/100)
    return "yes";
    else
    return "no";
    }
}
Console.WriteLine(Num(new Random().Next(10000,100000)));
