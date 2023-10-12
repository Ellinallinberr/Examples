//Задача 67. Напишите программу которая принимает число N  и на выходже выдает сумму цифр в числе.

﻿// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int digitSum(int num)
// {

//     if(num > 0)
//     {
//     return  digitSum(num/10)+num%10;
//     } else return 0;

// }

// int num = ReadData("Введите число");
// Console.WriteLine($"Сумма цифр { digitSum(num)}");

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumDigitRec(int num)
{

    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }

}

int number=ReadData($"Введите число: ");
System.Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumDigitRec(number)}.");
