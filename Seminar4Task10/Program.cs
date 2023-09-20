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
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumber = sumOfNumber + i;
        //sumOfNumber+=i;
    }
    return sumOfNumber;
}

int GausseSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber=(numA*(numA+1))/2;
    return sumOfNumber;
}
int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;    //ВЫЧИСЛЯЕТ ВРЕМЯ ОБРАБОТКИ МЕТОДА ВЫЧИСЛЕНИЯ
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма чисел от 1 до " + numberA + " (простой)равна " + res1);
PrintResult("Сумма чисел от 1 до " + numberA + " (Гаусса)равна " + res2);