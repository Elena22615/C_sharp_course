void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void Mass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int smalest = 0;

    for (int i = 0; i < row_size; i++)
    {
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
        Console.Write($"{num,4} ");

        if (amount > num)
        {
            amount = num;
            smalest = i;
        }
    }
    Console.WriteLine();
    Console.Write($"{smalest + 1}");
}    


    Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Mass(arr_1);
