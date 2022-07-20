//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого.
//массив размером 2 x 2 x 2

int [,,] FillArray (int rows, int columns, int depth)
{
        int[, ,] newArray = new int[rows, columns, depth];
        int count = new Random().Next(10, 20);
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                for (int h = 0; h < depth; h++)
                {
                    newArray[i, j, h] = count++;
                }
            }
        }
        return newArray;
}           

void PrintArray (int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            string strTab = "";
            for (int h = 0; h < arr.GetLength(2); h++)
            {
                string str = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str += String.Format("[{0},{1},{2}]={3, -6}",
                        i, j, h, arr[i, j, h]);
                }
                Console.WriteLine(strTab + str);
                strTab += "   ";
            }
            Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива");
Console.Write("Высота массива =  ");
int countRows= Convert.ToInt32(Console.ReadLine());
Console.Write("Ширина массива =  ");
int countColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Глубина масива  = ");
int countDepth = Convert.ToInt32(Console.ReadLine());

while (countRows <= 0 || countColumns <= 0 || countDepth <= 0)
{
    Console.Write("Высота массива =  ");
    countRows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Ширина массива =  ");
    countColumns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Глубина масива  = ");
    countDepth = Convert.ToInt32(Console.ReadLine());
}

 PrintArray(FillArray(countRows, countColumns, countDepth));