// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y) Если минимальное значение -100, максимальное 100

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = 100;

if (number == 1)
{
    Console.WriteLine("Возможный диапазон координат точек x и y в 1-ой четверти");
    while (1 <= num)
    {
        Console.Write($" {num}");
        num--;
    }
}
else if (number == 2)
{
    Console.WriteLine("Возможный диапазон координат точек x и y во 2-ой четверти");
    num = -100;
    while (num <= 100)
    {
        if (num > 0 || num < 0)
        Console.Write($" {num}");
        num++;
    }
}
else if (number == 3)
{
    Console.WriteLine("Возможный диапазон координат точек x и y в 3-ей четверти");
    num = -1;
    while (-100 <= num)
    {
        Console.Write($" {num}");
        num--;
    }
}
else if (number == 4)
{
    
    Console.Write("Возможный диапазон координат точек x и y в 4-ой четверти: ");
    while (-100 <= num)
    {
        if (num > 0 || num < 0)
            Console.Write($" {num}");
            num--;
    }
    
}