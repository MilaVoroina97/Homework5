// Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.

void CheckPallindrom(int[] massiv)
{
    int size = massiv.Length;
    int count = 0;

    for(int i = 0; i < size/2; i++)
    {
        if(massiv[i] != massiv[size-1 -i])
        {
            Console.WriteLine("Нет. Данное число не является палиндромом");
            break;
        }
        else
        {
            if(massiv[i] == massiv[size-1 -i])
            {
                count+=1;
            }
        }
        if(count == size/2)
        {
            Console.WriteLine("Да. Данное число является палиндромом");
        }
    }

}
int[] FillArray(string x)
{
    int[] array = new int[x.Length];
    int j = 0;
    for (int i = 0; i < x.Length; i++)
    {
        string y = "";
        y = y + x[i];
        array[j] = Convert.ToInt32(y);
        j++;
    }
    return array;
}
try
{
    Console.WriteLine("Введите любое целое число: ");
    string N = Console.ReadLine();
    int[] result = FillArray(N);
    CheckPallindrom(result);

}
catch 
{
    
    Console.WriteLine("Пожалуйста, введите целое число.");
}





