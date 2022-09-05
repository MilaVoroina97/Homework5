// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] NewArray(int N, int min, int max)
{
    if (max < min)
    {
        int temp = min;
        min = max;
        temp = max;
    }
    Random sourceGen = new Random();
    double[] array = new double[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (Double) (sourceGen.Next(min) + 1) / (sourceGen.Next(max) + 1);
        if (i!= array.Length-1) Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
    return array;
}

double Difference (double[] answer)
{
    double difference = 0;
    double min = answer[0];
    double max = answer[0]; 
    for (int i = 0; i < answer.Length; i++)
    {
        if(answer[i] < min)
        {
            min = answer[i];
        }
        else
        {
            if (answer[i] > max)
            {
                max = answer[i];
            }
        }
       
    }
    Console.WriteLine($"Максимальное число в массиве: {max}");
    Console.WriteLine($"Минимальное число в массиве: {min}");
    difference = (max -min);
    return difference;

}
Console.WriteLine("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, с которого будет начинаться массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которым будет заканчиваться массив:");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = NewArray(N, min, max);
double result = Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями равна :{result}");
