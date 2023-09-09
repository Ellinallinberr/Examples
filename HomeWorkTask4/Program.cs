Console.WriteLine("Введите три числа: ");
int numA = int.Parse(Console.ReadLine());//??"0"
Console.WriteLine(". ");
int numB = int.Parse(Console.ReadLine());//??"0"
Console.WriteLine(". ");
int numC = int.Parse(Console.ReadLine());//??"0"

int numMax = numA;
if (numB> numMax) numMax = numB;
if (numC> numMax) numMax = numC;

Console.WriteLine ("Число "+ numMax +" больше других чисел");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.