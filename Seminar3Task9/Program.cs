//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string BuildLine(int num,int pow)
{
    string res = String.Empty;
    for (int i = 1;i<=num;i++)
    {
        res = res + Math.Pow(i,pow) + " ";
    }

    return res;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int Num = ReadData("Enter N");
int pow = ReadData("Enter pow");
Console.WriteLine("Квадраты числа N: "+BuildLine(Num,pow));