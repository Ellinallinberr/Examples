Console.WriteLine("Введите трёхзначное число: ");
string num = Console.ReadLine();

if(int.Parse(num) > 1000 || int.Parse(num) < 99) {
    Console.WriteLine("Число не трёхзначное");
    return;
}

Console.WriteLine(num[1]);

//№10 Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую цифру этого числа.

