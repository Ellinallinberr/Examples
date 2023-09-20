// №27 Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int SumDigit(int num)

{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
int num = ReadData("Введите число: ");
Console.WriteLine("Сумма чисел в числе " + num + " равна " + SumDigit(num));