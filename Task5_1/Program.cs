

Console.WriteLine("Введите число N для определения размерности пространства: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] coordinat1 = new double[N];
for(int i = 0; i < coordinat1.Length; i++)
{
    Console.Write("Введите координаты первой точки ");
    coordinat1[i] = Convert.ToInt16(Console.ReadLine());

}
        void PrintArray(double[] table)
            {
            for (int i = 0; i < table.Length; i++)
                {
                    
                    Console.Write(table[i] + "\t" );

                    Console.WriteLine();
                }
            }
double[] coordinat2 = new double[N];
for(int j = 0; j < coordinat2.Length; j++)
{
    Console.Write("Введите координаты второй точки: ");
    coordinat2[j] = Convert.ToInt16(Console.ReadLine()); 

}
PrintArray(coordinat1);
Console.WriteLine();
PrintArray(coordinat2);
double result = 0;
for(int i = 0; i < N; i++)
{
    
    result = result + Math.Pow((coordinat2[i]-coordinat1[i]), 2);  
    Console.WriteLine(result);
    Console.WriteLine();
    
}
Console.WriteLine();
Console.WriteLine(Math.Sqrt(result));


