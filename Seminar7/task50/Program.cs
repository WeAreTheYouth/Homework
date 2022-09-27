// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int height = 5;
int width = 5;

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

Console.Write("Введите позицию элемента через пробел: ");
string line = Console.ReadLine();
string[] parts = line.Split(' ');
int[] position = new int[2];
position[0] = int.Parse(parts[0]);
position[1] = int.Parse(parts[1]);

if (position[0] <= numbers.GetLength(0) && position[1] <= numbers.GetLength(1))
{
    Console.WriteLine($"На позиции {position[0]} {position[1]} значение = {numbers[position[0] - 1, position[1] - 1]}");
}
else
{
    Console.Write("Такого элемента нет");
}