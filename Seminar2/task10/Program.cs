Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Вторая цифра {(number % 100) / 10}");