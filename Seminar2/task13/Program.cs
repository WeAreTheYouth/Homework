Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    char threeNumber = number.ToString()[2];
    Console.WriteLine($"Третья цифра {threeNumber}");
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}