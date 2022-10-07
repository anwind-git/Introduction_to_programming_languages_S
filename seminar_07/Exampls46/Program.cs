// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void Zadaha46()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colunms = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{colunms}");

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadaha46();
