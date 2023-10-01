﻿// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

string DecToBin(int num)
{
    string line ="";
    while(num>0)
    {
        line = num%2+line;
        num=num/2;
    }
    return line;
}

// Переводит число в двоичное
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
}

//String bin = Convert.ToString(a, 2);
//String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);

int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
Console.WriteLine();
Console.Write($"Двоичное представление числа(Recurent): {DecToBinRec(number)}");
Console.WriteLine();
Console.WriteLine( Convert.ToString(number, 2));
Console.WriteLine( Convert.ToString(number, 8));
Console.WriteLine( Convert.ToString(number, 16));
