// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
double summa = 1;

while (i <= N)
{
    summa = Math.Pow(i, 2);
    Console.WriteLine($"Квадрат числа {i}: ({i} * {i}) = {summa}");
    i++;
}