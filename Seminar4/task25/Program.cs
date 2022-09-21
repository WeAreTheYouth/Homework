// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.Write("Введите число A ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B ");
int numB = int.Parse(Console.ReadLine());
int degree = 1;

int GetDegree(int numA, int numB)
{
    for (int i = 1; i <= numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
}
Console.WriteLine($"{numA} в {numB} степени = {GetDegree(numA, numB)}");