// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
double[] array = new double[number];
for (int i = 1; i <= number; i++)
{
    array[i - 1] = Math.Pow(i, 3);
    Console.Write($"{array[i - 1]} ");
}
