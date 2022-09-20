// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 % num1 == 0)
{
    Console.WriteLine("кратно");
}
else
{
     Console.WriteLine("не кратно, остаток = " + num2 % num1);
}