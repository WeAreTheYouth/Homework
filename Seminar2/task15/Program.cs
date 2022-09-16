Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number > 0 && number < 6)
{
    Console.WriteLine("Будний день");
}
else if (number > 5 && number < 8)
{
    Console.WriteLine("Выходной день");
}