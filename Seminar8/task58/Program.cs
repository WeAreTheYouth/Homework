// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int height = 5;
int width = 5;

Console.WriteLine("Первая матрица");
int[,] matrix1 = new int[height, width];
Fill2DArray(matrix1);
Print2DArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
int[,] matrix2 = new int[height, width];
Fill2DArray(matrix2);
Print2DArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
int[,] product = MultiplyMatrix(matrix1, matrix2);
Print2DArray(product);

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return product;
}
