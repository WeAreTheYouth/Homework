// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от M до N = {GetSum(num1, num2)}");

int GetSum(int min, int max)
{
    int sum = 0;
    if (min == max)
    {
        return min;
    }
    sum += max;
    return GetSum(min, max - 1) + sum;

}