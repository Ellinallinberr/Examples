//Задача 59: Задайтедвумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на
//пересечении которых расположен наименьший элемент
//массива.

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void FindMin(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0; y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArr(int[,] arr, int x, int y)
{
    int k = 0; int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x)
        {
        }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y)
                {
                }
                else
                {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArr;
}

int[,] array2D = new int[4, 4];
Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
int x = -1;
int y = -1;
FindMin(array2D, ref x, ref y);
int[,] outArr = CreateArr(array2D, x, y);
Print2DArray(outArr);
