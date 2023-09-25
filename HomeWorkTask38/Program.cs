// №38 Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива

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

int[] array = GenerateRandomArray(15, 1, 100);

// Находим минимальное и максимальное значения в массиве
int min = array[0];
int max = array[0];

foreach (int number in array)
{
    if (number < min)
    {
        min = number;
    }

    if (number > max)
    {
        max = number;
    }
}

// Находим разницу между максимальным и минимальным значением
double difference = max - min;

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Генерация массива из случайных чисел и вывод

PrintArray("Сгенерированный массив:\n", array);//\n-начинаем с новой строки

Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine("Максимальное значение: " + max);
PrintResult("Разница между максимальным и минимальным: " + difference);
