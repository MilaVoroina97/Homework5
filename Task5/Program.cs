// Напишите программу, которая принимает на вход целое положительное число N и координаты двух точек и находит
// расстояние между ними в N-мерном пространстве.

Console.WriteLine("Введите размерность пространства:");
int N = Convert.ToInt32(Console.ReadLine());
int[] NewArray(int n, int min, int max)
{
    if (max < min)
    {
        int temp = min;
        min = max;
        temp = max;
    }
    var rand = new Random();
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min,max+1);
        if (i!= array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
    return array;
}
Console.WriteLine("Введите размерность пространства:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, с которого будет начинаться координаты первой точки: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, с которого будет заканчиваться координаты первой точки:");
int max = Convert.ToInt32(Console.ReadLine());
int[] result = NewArray(N, min, max);

Console.WriteLine("Введите число, с которого будет начинаться координаты второй точки: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, с которого будет заканчиваться координаты второй точки:");
int max1 = Convert.ToInt32(Console.ReadLine());
int[] result1 = NewArray(N, min1, max1);

int[] result2 = new int[N];

for(int i = 0; i < N; i++)
{
    for(int j = 0; j < N; j++)
    {
        for(int x = 0; x < N; x++)
        {
            result2[x] = result1[j] - result[i];
            Console.Write(result[x]);
        }
    }
}








