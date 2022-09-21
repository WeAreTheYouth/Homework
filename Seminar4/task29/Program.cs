// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

PrintArray(CreateArray());
