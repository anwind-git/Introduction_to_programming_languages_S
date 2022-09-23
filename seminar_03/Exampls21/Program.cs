// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

Console.Write("Координаты точки А(x): ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки А(y): ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Координаты точки B(x): ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки B(y): ");
int by = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
Console.WriteLine($"Расстояние между 2-мя точками {result}");