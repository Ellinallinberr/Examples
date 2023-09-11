Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

if(int.Parse(num) < 99) 
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

Console.WriteLine(num[2]);
