// 1. двумерный массив из двух строк и двадцати двух столбцов.
// 2. В первой строке, записано количество мячей, забитых футбольной командой в той 
//    или иной игре.
// 3. Во второй, количество пропущенных мячей в этой же игре.
// а) Для каждой проведенной игры напечатать: Выигрыш, Ничья, Проигрыш
// б) Определить количество выигрышей данной команды.
// в)  Определить количество выгрышей и количество проигрышей данной команды.
// г) Определить количество выигрышей, ничьих и проигрышей данной команды.
// д) Определить, в сколькихи играх разность забитых и пропущенных мячей была больше или равной трем.
// e) определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью - 1, за проигрыш - 0)
void Dop1()
{
    int rows = 2;
    int colunms = 22;
    Console.WriteLine();

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
    int defeat = 0;
    int victory = 0;
    int draw =0;
    int glasses = 0;
    int difference = 0;
    Console.WriteLine("--------------------------");
    for(int i = 0; i < colunms; i++ )
    {
        if(numbers[0, i] > numbers[1, i])
        {
            Console.Write($"Игра №{i+1} - Победа {numbers[0, i]} : {numbers[1, i]} | ");
            victory += 1; 
            glasses += 3;
            if((numbers[0, i] - numbers[1, i]) > 3 || 
               (numbers[0, i] - numbers[1, i]) == 3)
               {
                difference += 1;
               }
        }
        else if(numbers[0, i] == numbers[1, i])
        {
            Console.Write($"Игра №{i+1} - Ничья {numbers[0, i]} : {numbers[1, i]} | ");
            draw += 1;
            glasses += 1;
        }
        else if(numbers[0, i] < numbers[1, i])
        {
            Console.Write($"Игра №{i+1} - Поражение {numbers[0, i]} : {numbers[1, i]} | ");
            defeat += 1;
            if((numbers[1, i] - numbers[0, i]) > 3 || 
               (numbers[1, i] - numbers[0, i]) == 3)
               {
                difference += 1;
               }
        }
    }
    Console.WriteLine();
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Побед: {victory}");
    Console.WriteLine($"Поражений: {defeat}");
    Console.WriteLine($"Ничья: {draw}");
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Общее число очков за проведенные матчи: {glasses}");
    Console.WriteLine("--------------------------");
    Console.WriteLine("--------------------------");
    Console.WriteLine($"разность забитых и пропущенных мячей была больше или равной трем в {difference} играх");
    Console.WriteLine("--------------------------");
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
            numbers[i, j] = random.Next(0, 6);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    Console.Write($"В 1 строке, количество забитых мячей, во втророй пропущенных в той или иной игре");
    Console.WriteLine();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

Dop1();
