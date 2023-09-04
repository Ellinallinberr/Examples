Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");
//последняя цифра числа

//Console.WriteLine("Введите число:");
//int num = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine(num % 10);