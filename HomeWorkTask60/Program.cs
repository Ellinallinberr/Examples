// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//чтения трехмерного массива с консоли
// int[,,] Read3DArray(string prompt, int x, int y, int z)
//     {
//         Console.WriteLine(prompt);
//         int[,,] array = new int[x, y, z];//Здесь создается трехмерный массив
//         for (int i = 0; i < x; i++)
//         {
//             for (int j = 0; j < y; j++)
//             {
//                 string[] values = Console.ReadLine().Split(' '); //подстроки по пробелам
//                 for (int k = 0; k < z; k++)
//                 {
//                     array[i, j, k] = int.Parse(values[k]); //конвертируется каждая подстрока в целое число
//                 }
//             }
//         }
//         return array;
//     }
int[,,] GenerateRandom3DArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = random.Next(minValue, maxValue + 1);
            }
        }
    }

    return array;
}

void Print3DArrayWithIndices(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i,j,k]}({i},{j},{k}) "); //Значение элемента и его индексы выводятся
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

 Console.WriteLine("Введите размеры трёхмерного массива (x y z):");
        string[] sizes = Console.ReadLine().Split(' ');
        int x = int.Parse(sizes[0]);
        int y = int.Parse(sizes[1]);
        int z = int.Parse(sizes[2]);
        int[,,] array = GenerateRandom3DArray(2,2,2,10,99);
        Print3DArrayWithIndices(array);
    