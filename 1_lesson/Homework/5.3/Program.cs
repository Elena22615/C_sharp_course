void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();

}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    return arr;
}

void MinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {

        if (max<arr[i])
            max=arr[i];
        else if(min>arr[i])
            min=arr[i];    
      
    }
    Console.Write($"Max: {max}, min:  {min}  ");
    Console.WriteLine($"Max-Min: {max} - ({min}) = {Math.Round(max-min,2)}");
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));

Print(arr_1);
MinMax(arr_1);