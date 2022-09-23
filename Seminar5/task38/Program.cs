// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

int[] numbers = CreateArray(10);
PrintArray(numbers);
FindMinElement(numbers);
FindMaxElement(numbers);
Console.WriteLine($"Минимальный объект массива = {FindMinElement(numbers)}, максимальный = {FindMaxElement(numbers)}, разница = {FindMaxElement(numbers) - FindMinElement(numbers)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int FindMinElement(int[] array)
{
    int minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
        }
    }
    return minElement;
}

int FindMaxElement(int[] array)
{
    int maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}



/*int size = 10;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}

int minElement = array[0];
int maxElement = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (minElement > array[i])
    {
        minElement = array[i];
    }
    if (maxElement < array[i])
    {
        maxElement = array[i];
    }
}

Console.WriteLine($"мин {minElement} макс {maxElement} разница = {maxElement - minElement}");*/