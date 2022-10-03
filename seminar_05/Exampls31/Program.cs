// Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива

void Task31()
{
    int[] array = new int[12];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-9, 10);
    string arr = string.Join(", ", array);
    Console.WriteLine($"Массив из 12 элементов: [" + arr + "]");
    Negative(array);
    Positive(array);

}

void Negative(int[] array)
{
    int negative_sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            negative_sum += array[i];
        }
    }
    Console.WriteLine($"Сумма отрицательных чисел: " + negative_sum);
}

void Positive(int[] array)
{
    int positive_sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            positive_sum += array[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел: " + positive_sum);
}

Task31();