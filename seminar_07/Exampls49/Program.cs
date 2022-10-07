// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.

void Zadaha49()
{
    int rows = 3;
    int colunms = 4;
    Console.WriteLine($"Массив размера {rows}x{colunms}");

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j ++)
        {
            if(numbers[i, j]%2 == 0)
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
    Console.WriteLine();
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
            numbers[i, j] = random.Next(0, 10);
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

Zadaha49();