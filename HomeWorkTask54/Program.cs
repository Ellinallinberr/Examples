//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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
//Метод сортировки по возрастанию или убыванию
void OrderRowsDescending(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] array = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                array[j] = matrix[i, j];
            }

            Array.Sort(array); // Сортируем по возрастанию
            //Array.Reverse(array); // Переворачиваем, чтобы получить убывающий порядок

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = array[j];
            }
        }
    }

int[,] arr2D = Fill2DArray(10,10,10,1);
Print2DArray(arr2D);
Console.WriteLine("_______________________________________");
OrderRowsDescending(arr2D);
Print2DArray(arr2D);