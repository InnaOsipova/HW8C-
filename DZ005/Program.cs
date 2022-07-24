//Заполните спирально массив 4 на 4.

int[] FillArray (int n)
{
    int[] newArray = new int [n*n];
    for (int i = 0; i < n*n; i++)
    {
        newArray [i] = i+1;
    }
    return newArray;
}


int number = 4;
int [] array = FillArray(number);
Console.Clear();
int origRow = Console.CursorTop;
int origCol = Console.CursorLeft;

for (int i = 0; i < number*number; i++)
{
       if (array[i] <= number)
        {
            origCol += 4;
            Console.SetCursorPosition(origCol, origRow);
            Console.Write (array[i]);

        }
    
        if (array[i] > number && array[i] <= number+number-1)
        {
           origRow += 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
        if (array[i] > number+number-1 && array[i] <= number*3-2)
        {
           origCol -= 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
        if (array[i] > number*3-2 && array[i] <= number*3)
        {
           origRow -= 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
        if (array[i] > number*3 && array[i] <= number*3+2)
        {
           origCol += 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
        if (array[i] > number*3+2 && array[i] <= number*4-1)
        {
           origRow += 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
        if (array[i] > number*4-1 && array[i] <= number*4)
        {
           origCol -= 4;
           Console.SetCursorPosition(origCol, origRow);
           Console.Write (array[i]);

        }
    }