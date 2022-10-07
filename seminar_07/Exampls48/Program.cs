// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A = m+n. 
// Выведите полученный массив на экран.

void Zadaha48()
{
    int rows = 3;
    int colunms = 4;
    Console.WriteLine($"Массив размера {rows}x{colunms}");

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers[i, j] = i + j;
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

Zadaha48();