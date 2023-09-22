// №34 Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим количество четных элементов в заданном диапазоне
int CountElm(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
//передаем длину массива и генерируем нужное количество чисел
int[] GenerateThreeDigitNumbersArray(int length)
{
    Random random = new Random();
    int[] numbersArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        int randomNumber = random.Next(100, 1000);
        numbersArray[i] = randomNumber;
    }

    return numbersArray;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

Console.WriteLine("Введите число: ");
string length = Console.ReadLine(); 
int[] result = GenerateThreeDigitNumbersArray(int.Parse(length));
int count = CountElm(result);
PrintArray(result);
PrintResult($"{count} четных элементов");
