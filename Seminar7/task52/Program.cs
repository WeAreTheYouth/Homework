// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int height = 3;
int width = 3;

double[,] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{Math.Round(numbers[i, j], 1),2} ");
        }
        Console.WriteLine();
    }
}

double[] average = new double[numbers.GetLength(1)];
for(int i = 0; i < numbers.GetLength(1); i++)
{
    for(int j = 0; j < numbers.GetLength(0); j++)
    {
        average[i] = average[i] + numbers[j, i];
    }
    average[i] = Math.Round(average[i] / numbers.GetLength(0), 1);
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

Console.Write($"Средне арифметическое столбцов: ");
PrintArray(average);