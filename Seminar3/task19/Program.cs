// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());



if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}