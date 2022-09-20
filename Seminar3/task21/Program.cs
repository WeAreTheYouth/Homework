// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки XA, YA и ZA: ");
string xyzA = Console.ReadLine();
string[] partA = xyzA.Split (' ');
int xa = int.Parse (partA[0]);
int ya = int.Parse (partA[1]);
int za = int.Parse (partA[2]);

Console.WriteLine("Введите координаты второй точки XB, YB и ZB: ");
string xyzB = Console.ReadLine();
string[] partsB = xyzB.Split(' ');
int xb = int.Parse (partsB[0]);
int yb = int.Parse (partsB[1]);
int zb = int.Parse (partsB[2]);

double length = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2) );
Console.WriteLine($"Расстояние между A и B = {length}");
