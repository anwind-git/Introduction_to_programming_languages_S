﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine(number);

int tens = number / 10;
int ones = number % 10;

if (tens > ones)
{
    Console.WriteLine(tens);
}
else
{
    Console.WriteLine(ones);
}