//функция возведения числа в квадрат

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Power(int x)
{
    return x * x;
}
Console.WriteLine(Power(num));