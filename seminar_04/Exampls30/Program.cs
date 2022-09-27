// выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] array = new int[8];

Random random = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(0, 2);

string arr = string.Join(", ", array);
Console.Write(arr);
