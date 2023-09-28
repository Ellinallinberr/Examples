//Задача 40: Напишите программу, которая принимает на вход три числа и
//проверяет, может ли существовать треугольник с сторонами такой длины.

double ReadData(){
    return double.Parse(Console.ReadLine()??"0");
}


bool isTrianglable(double a, double b, double c)
{
    return !(a+b <= c || b+c <= a || a+c <= b);
}


Console.WriteLine(isTrianglable(ReadData(),ReadData(),ReadData()));