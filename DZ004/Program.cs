//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого.
//массив размером 2 x 2 x 2

int [] FillArray (int count)
{
    int [] newArray = new int [count];
    for (int i = 0; i < count; i++)
    {
       newArray [i] = new Random().Next(10, 100);
    }
    return newArray;
}

int [] CheckUniqArray (int [] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int uniqEllement = arr[i];
        for (int j = i+1; j < arr.GetLength(0); j++)
        {
            if (arr[i] == arr[j])
            {
                arr[j] = new Random().Next(10, 100);
            }
        }
    }
    return arr;
    
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

int [,,] CreateCube (int []arr, int lines, int columns, int hiaght)
{
    int n = 0;
    int [,,] arrayCube = new int [lines, columns,  hiaght];
    for (int i = 0; i < lines ; i++){
    for (int j = 0; j < columns; j++){
    for (int h = 0; h < hiaght; h++)
    {
         arrayCube[i,j,h] = arr[n];
         n++;
    }
    }
    }
    
    return arrayCube;
}


int line = 2;
int column = 2;
int hi = 2;
int numbers = line*column*hi;

int [] matrix = new int [numbers];
matrix = FillArray(numbers);
CheckUniqArray(matrix);
PrintArray(CreateCube(matrix, line, column, hi));

