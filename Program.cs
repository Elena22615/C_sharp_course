﻿void Numbers(int m, int n)
{
    if (m > n)
        Console.Write($"{m} ");
    Numbers(m + 1, n);
}
Numbers(5, 8);