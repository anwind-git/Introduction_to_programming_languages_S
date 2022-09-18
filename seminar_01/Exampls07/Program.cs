// Напишите программу, которая на вход принимает одно число 
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
num1 = Math.Abs(num1);
int num2 = -num1;
while (num2 <= num1)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 1;
}
Console.WriteLine();