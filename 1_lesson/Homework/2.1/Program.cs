int Num (int num)
{
    Console.WriteLine(num);

    if (num < 1000)
         return num / 10 % 10;
    else
        return num;

}

Console.WriteLine(Num(new Random().Next(100,1000)));

