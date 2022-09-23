// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] numbers = CreateArray();
PrintArray(numbers);
Console.WriteLine($"Чисел больше нуля {GetSum(numbers)}");


int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

int GetSum(int[] array)
{
    int sum = 0;
    foreach (var elements in array)
    {
        if (elements > 0)
            sum++;
    }
    return sum;
}