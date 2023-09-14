//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

Console.WriteLine("Введите число: ");

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
