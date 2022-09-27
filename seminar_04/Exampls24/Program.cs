// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А

Console.Write("Введите число A: ");
int number_a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number_a; i++)
    sum = sum + i;

Console.WriteLine(sum);
