// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] NewArray(int N, int min, int max)
{
    if (max < min)
    {
        int temp = min;
        min = max;
        temp = max;
    }
    var rand = new Random();
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min,max+1);
        if (i!= array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
    return array;
}

int Summa(int[] result)
{
    int sum = 0;
    for(int i = 0; i < result.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum+=result[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, с которого будет начинаться массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которым будет заканчиваться массив:");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(N, min, max);
int summa = Summa(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summa}");