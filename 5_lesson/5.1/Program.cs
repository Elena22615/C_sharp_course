void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();

}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

void NumsChange(int[] arr_1)
{
       for (int i = 0; i < arr_1.Length; i++)
        arr_1[i] = -arr_1[i];
   
}

int[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
                   
Print(arr_1);
NumsChange(arr_1);
Print(arr_1);


// Замена положительных элементов отрицательными и обратно