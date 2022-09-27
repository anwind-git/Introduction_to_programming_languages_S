// принимает на вход число и выдаёт количество цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string Length = Convert.ToString(number);

int col = Length.Length;

Console.WriteLine(col);