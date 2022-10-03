// Напишите программу замены элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

void Task32()
{
    int[] array = new int[12];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-9, 10);
    string arr = string.Join(", ", array);
    Console.WriteLine($"Массив из 12 элементов: [" + arr + "]");
    Replacement(array);
}

void Replacement(int[] array)
{
    int number = 0;
    int[] array2 = new int[12];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            number = Math.Abs(array[i]);
            array2[i] = number;
        }
        if (array[i] > 0)
        {
            number = array[i] * -1;
            array2[i] = number;
        }
    }
    string arr2 = string.Join(", ", array2);
    Console.WriteLine($"Массив смена знаков: [" + arr2 + "]");
}

Task32();
