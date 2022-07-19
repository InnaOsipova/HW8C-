//Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.

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

int [,] StringOrdering (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(1)-1 )
            {
                if (arr[i,k+1] > arr[i,k])
                {
                    int x = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = x;
                    k++;
                 }
                 k++;
                
            }
            
        }
    }
    return arr;
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
Printarr (array);
Console.WriteLine();

StringOrdering(array);
Printarr (array);