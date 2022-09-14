Console.Write("Введите число ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
} else {
    Console.WriteLine("Число нечетное");
}