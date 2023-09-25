// №36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Генерация массива
int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Подсчет суммы элементов, стоящих на нечётных позициях 
int SumOddNumPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2) { sum += array[i]; }
    return sum;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Генерация массива из случайных чисел и вывод
int[] array = GenerateRandomArray(20, 0, 9);
PrintArray("Сгенерированный массив:\n", array);//\n-начинаем с новой строки

// Сумма элементов и вывод результата
int sum = SumOddNumPos(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях в массиве: {sum}");