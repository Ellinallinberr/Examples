Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 2)
{
    for (int index = 2; index <= num; index += 2)
    {
        Console.Write(index == num || index + 2 > num ? $"{index}." : $"{index}, ");
    }
}
else
{
    Console.WriteLine("Пожалуйста, введите число больше 1.");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
