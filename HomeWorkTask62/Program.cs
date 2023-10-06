// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//создает и заполняет двумерный массив размером size x size числами в спиральном порядке
int[,] FillSpiral(int size)
    {
        int[,] array = new int[size, size];
        int num = 1;

        for (int layer = 0; layer < size / 2 + size % 2; layer++)//проход по слоям спирали
        {
            for (int ptr = layer; ptr < size - layer; ptr++) // ptr- временная переменная для итерации через элементы одной из сторон спирали.
            {
                array[layer, ptr] = num++;
            }
            for (int ptr = layer + 1; ptr < size - layer; ptr++)
            {
                array[ptr, size - layer - 1] = num++;
            }
            for (int ptr = size - layer - 2; ptr >= layer; ptr--)
            {
                array[size - layer - 1, ptr] = num++;
            }
            for (int ptr = size - layer - 2; ptr > layer; ptr--)
            {
                array[ptr, layer] = num++;
            }
        }
        return array;
    }
// вывод двумерного массива
void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString("00") + " ");
            }
            Console.WriteLine();
        }
    }

 Console.WriteLine("Введите размер матрицы (n):");
        int size = int.Parse(Console.ReadLine());

        int[,] array = FillSpiral(size);
        PrintMatrix(array);

