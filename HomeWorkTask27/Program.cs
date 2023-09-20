// №27 Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

