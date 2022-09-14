Console.Write("Введите число a = ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);
Console.Write("Введите число b = ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);
Console.Write("Введите число c = ");
string inputC = Console.ReadLine();
int numberC = int.Parse(inputC);
var max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}

Console.WriteLine($"Самое большое число {max}");