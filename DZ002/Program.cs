//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] Fillarr (int lines, int columns )
{
    int[,] newarr = new int [lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newarr[i, j] =  new Random().Next(10, 100);

        }
    }
    return newarr;
}

void Printarr (int[,] arr )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr [i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [] MassivSumm (int[,] arr)
{
    int [] sumArray = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr [i,j];
        }
        sumArray[i] = sum;
    
    }
    return sumArray;
}

int MinSum (int [] arr)
{
    int min = arr[0];
    int numStr = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min) 
        {
            min = arr[i];
            numStr = i;
        }
            
    }
    return numStr;
}

Console.WriteLine("Введите размер массива");
Console.Write("Количество строк = ");
int countLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());

while (countLines <= 0 || countColumns <= 0)
{
    Console.Write("Количество строк = ");
    countLines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов = ");
    countColumns = Convert.ToInt32(Console.ReadLine());
}

int [,] array = Fillarr(countLines, countColumns);
Console.WriteLine("Готовый массив");
Printarr (array);
Console.WriteLine();

int NumberMinStr = MinSum(MassivSumm(array)) + 1;

Console.WriteLine($" Минимальная сумма элементов в строке - {NumberMinStr} ");

