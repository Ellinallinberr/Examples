// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//m=4;n=8
//4+5+6+7+8
// 30

int ReadData(string line)
{
    Console.Write(line);//Выводит строку
    int number = int.Parse(Console.ReadLine() ?? "0");//Преобразует считанную строку в целое число 
    return number;
}

int SumNaturalNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    else
    {
        return M + SumNaturalNumbers(M + 1, N); //  суммируем M с результатом для M+1.
    }
}

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

if (M <= N)
{
    int sum = SumNaturalNumbers(M, N);
    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
}
else
{
    Console.WriteLine("M должно быть меньше или равно N.");
}