// принимает на вход число N и выдаёт произведение чисел от 1 до N

Console.Write("Введите число N: ");
int number_n = Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 1; i <= number_n; i++)
{
    sum = sum * i;
}

Console.WriteLine(sum);