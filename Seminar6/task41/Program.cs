// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] numbers = InputNumbersArray();
PrintArray(numbers);
Console.WriteLine($"Чисел больше нуля {GetSum(numbers)}");

int[] InputNumbersArray()
{
    Console.WriteLine("Введите числа через пробел");
    string line = Console.ReadLine();
    string[] parts = line.Split(' ');
    int[] numbers = new int[parts.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(parts[i]);
    }
    return numbers;
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
