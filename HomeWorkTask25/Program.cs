//№25 Напишите цикл, который принимает на 
//вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long MyPow(int A, int B)
{
    long res = 1;
    while (B >= 0)
    {
        res = res * A;
        B = B - 1;
    }
    return res;
    
}


//A = A*

int A = ReadData("Введите первое число: ");
int B = ReadData("Введите степень: ");
Console.WriteLine("Число "+ A+" в степени "+ B +" = "+ MyPow(A,B));