// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите число, обозначающее размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] result = new int[N];
int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i!= array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
    return array;
}
int EvenNumbers(int[] massiv)
{
    int count = 0;
    for(int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] % 2 == 0)
        {
            count+= 1;
        }
    }
    return count;
}
FillArray(result);
int number = EvenNumbers(result);
Console.WriteLine($"Количество четных чисел в массиве: {number}");