// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта точка
void Zadaha17()
{
    Random random = new Random();
    int x = random.Next(-100, 100);
    int y = random.Next(-100, 100);
    Console.WriteLine($"Координата x:{x} Координата y:{y}");
    Vihislenia(x, y);
}
void Vihislenia(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находиться в 1 четверти плоскости");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находиться в 2 четверти плоскости");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находиться в 3 четверти плоскости");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка находиться в 4 четверти плоскости");
    }
    else
    {
        Console.WriteLine("Точка плоскости лежит на одной из осей");
    }
}
Zadaha17();