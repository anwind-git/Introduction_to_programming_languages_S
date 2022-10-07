//  Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.

void Zadaha51()
{
    int rows = 4;
    int colums = 5;
    Console.WriteLine($"Массив размера {rows}x{colums}");

    int[,] numbers = new int[rows, colums];

    FillArray(numbers);
    PrintArray(numbers);
    int sum = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            if(i == j)
            {
                sum += numbers[i, j];
            }
        }
    }
    Console.WriteLine(sum);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadaha51();

