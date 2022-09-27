// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

double[ , ] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);



int EnterInt(string promt)
{
    Console.Write(promt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().NextDouble() * 9 - 4;
        }
    }
}

void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{Math.Round(numbers[i, j], 1), 4} ");
        }
        Console.WriteLine();
    }
}
