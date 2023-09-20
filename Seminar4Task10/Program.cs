//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//1.Вводим чило пользователя
//2. вычисляем сумму
//3. выводим результат


int SimpleSum(int numA)
{
    int sumOfNumber = 0;
    for (int i = 0; i < numA; i++)
    {
        sumOfNumber = sumOfNumber + i;
        //sumOfNumber+=i;
    }
    return sumOfNumber;
}

int numberA = ReadData("Введите число А: ");

int res = SimpleSum(numberA);
PrintResult("Сумма чисел от 1 до " + numberA + " равна " + res);