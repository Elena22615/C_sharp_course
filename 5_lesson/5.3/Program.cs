// Загадайте одномерный массив из 123 случайных чисел. Найти кол-во эл массива, значения которых лежат в отрезке [10,99]
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
        arr[i] = new Random().Next(-100, 1000);
    return arr;
}

int CountDiap(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
            
    }
    return count;
}

int[] arr_1 = MassNums(int.Parse(Console.ReadLine()));                       
Print(arr_1);
Console.Write(CountDiap(arr_1));
