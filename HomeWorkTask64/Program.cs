//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//
int ReadData(string line)
{
    Console.Write(line);//Выводит строку
    int number = int.Parse(Console.ReadLine() ?? "0");//Преобразует считанную строку в целое число 
    return number;
}
//рекурсивный метод
void PrintNaturalNumbers(int N)
{
    if (N < 1)
    {
        return;
    }

    Console.WriteLine(N);
    PrintNaturalNumbers(N - 1);
}


Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральные числа от " + N + " до 1:");
PrintNaturalNumbers(N);
