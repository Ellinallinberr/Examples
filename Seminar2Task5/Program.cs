//Задача №16
//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// int numA = int.Parse (Console.ReadLine()??"0");
// int numB = int.Parse (Console.ReadLine()??"0");
// bool test1 = (numA == numB*numB);
// bool test2 = (numB == numA*numA);

// if (test1) Console.WriteLine ("Первое квадрат второго");
// if (test2) Console.WriteLine ("второе квадрат первого");
// if (!(test1||test2))
// {
//     Console.WriteLine ("Числа не квадраты друг друга");
// }

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (num1 == num2 * num2);
bool test2 = (num2 == num1 * num1);

Console.WriteLine((test1 || test2) ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");