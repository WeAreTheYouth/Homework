// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

int height = 5;
int width = 5;

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine();
int[] sumRows = GetArrayWithRowsSum(numbers);
int min = SortArray(sumRows);
Console.WriteLine($"Строка с самой маленькой суммой элементов - {Array.IndexOf(sumRows, min) + 1}, сумма элементов в ней - {min}");

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[] GetArrayWithRowsSum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(0); j++)
            sums[i] += array[i, j];
    return sums;
}

int SortArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
        }
    }
    return min;
}
