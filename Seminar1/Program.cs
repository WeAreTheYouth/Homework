Console.Write("Введите число a = ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);
Console.Write("Введите число b = ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);
if (numberA > numberB) {
    Console.WriteLine($"Число a = {numberA} больше");
}
if (numberA < numberB) {
    Console.WriteLine($"Число b = {numberB} больше");
}
if (numberA == numberB) {
    Console.WriteLine("Числа равны");
}