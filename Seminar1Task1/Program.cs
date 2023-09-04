System.Console.WriteLine("Введите два числа");
int numb1 = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());
int x = numb2 * numb2;
if (numb1 == x) 
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else 
{
 System.Console.WriteLine("первое число не является квадратом второго");
}
