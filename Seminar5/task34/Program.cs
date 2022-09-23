// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = CreateArray(10);
PrintArray(array);
Console.WriteLine($"Четных чисел в массиве {CalcSum(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CalcSum(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        sum++;
    }
    return sum;
}

/*int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}

int sum = 0;

foreach (int element in array)
{
    if (element % 2 == 0)
        sum++;
}
Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве - {sum}");*/