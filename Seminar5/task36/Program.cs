// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] numbers = CreateArray(10);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов на нечетных позициях = {CalcOddSum(numbers)}");

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

int CalcOddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}



/*int size = 8;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}

int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");*/