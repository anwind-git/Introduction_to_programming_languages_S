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

int num1 = bx - ax;
int num2 = by - ay;

double result = Math.Sqrt(num1 * num1 + num2 * num2);
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между 2-мя точками {result}");
Console.WriteLine(result);