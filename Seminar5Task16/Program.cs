//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Проверяет, есть ли число
string Check(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return $"Есть, индекс {i}";
    return "Нет";
}

// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}


int[] array = {1, -2, 5, 6, 58, 7, -3, -42, 63, 15};
OutputArray(array);

int element = Prompt("Введите число для поиска: ");

Console.WriteLine(Check(array, element));