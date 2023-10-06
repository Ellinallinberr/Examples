//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Чтения пользовательской матрицы с консоли
int[,] ReadMatrix(string prompt, int rows, int cols)
    {
        Console.WriteLine(prompt); //выводит на консоль сообщение
        int[,] matrix = new int[rows, cols]; //создается двумерный массив 
        for (int i = 0; i < rows; i++) 
        {
            string[] rowValues = Console.ReadLine().Split(' '); //Этот код считывает строку введенную пользователем с консоли, разбивает ее на подстроки по пробелам, и сохраняет эти подстроки в массив 
            for (int j = 0; j < cols; j++) 
            {
                matrix[i, j] = int.Parse(rowValues[j]);//конвертируется каждая подстрока в целое число
            }
        }
        return matrix;
    }
//печать матрицы
void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
//умножение двух матриц a и b.
int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0))//Если количество столбцов в матрице a не равно количеству строк в матрице b, то умножение матриц невозможно
        {
            throw new InvalidOperationException("Матрицы невозможно умножить.");
        }

        int[,] product = new int[a.GetLength(0), b.GetLength(1)];//создается новая матрица
        for (int i = 0; i < a.GetLength(0); i++) //перебирает строки матрицы a
        {
            for (int j = 0; j < b.GetLength(1); j++)//перебирает столбцы матрицы b
            {
                for (int k = 0; k < a.GetLength(1); k++)//умножение элементов строк матрицы a на элементы столбцов матрицы b и суммирование
                {
                    product[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return product;
    }



Console.WriteLine("Введите размер первой матрицы через пробел (n m):");
        string[] sizes = Console.ReadLine().Split(' ');
        int rowsA = int.Parse(sizes[0]);
        int colsA = int.Parse(sizes[1]);

        int[,] matrixA = ReadMatrix("Введите первую матрицу:", rowsA, colsA);

        Console.WriteLine("Введите размер второй матрицы (n m):");
        sizes = Console.ReadLine().Split(' ');
        int rowsB = int.Parse(sizes[0]);
        int colsB = int.Parse(sizes[1]);

        int[,] matrixB = ReadMatrix("Введите вторую матрицу:", rowsB, colsB);

        int[,] result = MultiplyMatrices(matrixA, matrixB);
        Console.WriteLine("Результирующая матрица:");
        PrintMatrix(result);