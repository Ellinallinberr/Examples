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

// //Вводим данные
// string ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     string data = Console.ReadLine();
//     return data;
// }

// //Функция сложения
// double plus(int a, int b)
// {
//     double result = a + b;
//     return result;
// }

// //Функция вычитания
// double minus(int a, int b)
// {
//     double result = a - b;
//     return result;
// }

// //Функция умножения
// double multiplication(int a, int b)
// {
//     double result = a * b;
//     return result;
// }

// //Функция деления
// double division(int a, int b)
// {
//     double result = a / b;
//     return result;
// }

// //Функция возведения в степень
// double degree(int a, int b)
// {
//     double result = Math.Pow(a, b);
//     return result;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }



// int a = int.Parse(ReadData("Введите число А"));
// int b = int.Parse(ReadData("Введите число B"));
// string operand = ReadData("Введите операцию (+, -, *, /, ^)");

// //double result = getResult(a, b, operand);

// double result = 0;

// switch (operand)
// {
//     case "+": 
//     result = plus(a, b);
//     break;
//     case "-": 
//     result = minus(a, b);
//     break;
//     case "*": 
//     result = multiplication(a, b);
//     break;
//     case "/": 
//     result = division(a, b);
//     break;
//     case "^": 
//     result = degree(a, b);
//     break;
//     default: Console.WriteLine("Что-то пошло не так");
//     break;
// }

// PrintResult("Результат операции = " + result);