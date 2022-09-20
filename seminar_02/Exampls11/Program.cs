// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine("Случайное число: " + number);

int number1 = number / 100;
int number3 = number % 10;

Console.WriteLine("Выводим только 1 и 3 число: " + number1 + number3);