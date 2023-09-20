﻿// Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал

// Вывод сообщения и запись введённых данных
string[] Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    string[] names = value.Replace(".", ",").Replace(" ", "").Split(",");

    return names;
}
// Выбирает случайный индекс массива
int RandomName(int length)
{
    return new Random().Next(0, length);
}

string[] names = Prompt("Введите имена через запятую или точку: ");

Console.WriteLine(names[RandomName(names.Length)]);

//Не мое решение,просто сохранила