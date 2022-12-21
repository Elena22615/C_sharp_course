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

int[,] Mass(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];
    return pr_matrix;

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
Print(arr_1);
