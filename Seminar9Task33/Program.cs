﻿// ---------------------------------------------------------------------
//                                 Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// N=5 ->  5 4 3 2 1
//GenLineRec(5)     5
//GenLineRec(4)       4
//GenLineRec(3)         3
//GenLineRec(2)           2
//GenLineRec(1)             1

//-------------------               0
//-------------------           -1 

void GenLineRec(int num)
{
    Console.Write(num+" ");
    if(num<=1)
    {
    }
    else
    {
       GenLineRec(num-1);
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);
