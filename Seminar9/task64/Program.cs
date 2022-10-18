// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
GetNums(num);

void GetNums(int num)
{
    if (num < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{num} ");
    GetNums(num - 1);
}