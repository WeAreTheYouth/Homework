Console.Write("Введите число ");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine($"Четные числа до {number}");
for (int i = 2; i <= number; i = i + 2 ){
    Console.WriteLine($"{i}");
}