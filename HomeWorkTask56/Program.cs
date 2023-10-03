//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

int MinSumRaw(int[, ]arr)
{
    int outN =0;
    int Sum = int.MaxValue;
    for(int i =0;i<arr.GetLength(0);i++)
    {
        int sumRow = 0;
        for(int j=0; j <arr.GetLength(1);j++)
        {
            sumRow = sumRow + arr[i,j];
        }
        if(sumRow<Sum)
        {
            Sum=sumRow;
            outN=i;
        }
    }
    return outN;
}
//выводит строку отдельно
 void PrintRow(int[,] arr, int rowIndex)
{
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[rowIndex, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr2D = Fill2DArray(4,4,3,1);
int minSumRow = MinSumRaw(arr2D);
Print2DArray(arr2D);
Console.WriteLine("_______________________________________");
Console.WriteLine("Строка с наименьшей суммой чисел: "+ (minSumRow + 1));
PrintRow(arr2D,minSumRow);
