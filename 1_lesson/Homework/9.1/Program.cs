void Numbers(int m, int n)
{
    if (m > n) return;
      {
        if (m % 2 == 0)
        Console.Write($"{m} ");
        Numbers(m + 2, n);
              
      }
}
Numbers(1, 5);