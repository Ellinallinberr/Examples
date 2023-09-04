Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? InputNum = Console.ReadLine();//??"0";
//Проверяем данные на их наличие
if(InputNum!=null)
{
    //Парсим введенное число
    // int num = int.Parse(inputNum);
    // //Находим квадрат числа
    // int res = num*num;
    // // Выводим данные в консоль 
    // Console.WriteLine(res);
    Console.WriteLine("Квадрат числа: "+(int)Math.Pow(int.Parse(InputNum),2));
}
