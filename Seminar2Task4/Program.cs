//Задача №14
//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");

int GetNum()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNum();

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратное" : "Не кратно");