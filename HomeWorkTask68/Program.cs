// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


int ReadData(string line)
{
    Console.Write(line);//Выводит строку
    int number = int.Parse(Console.ReadLine() ?? "0");//Преобразует считанную строку в целое число 
    return number;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n} равно {result}");
