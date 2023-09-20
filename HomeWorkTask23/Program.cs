//Внутри класса Answer напишите метод ShowCube,
// который принимает на вход число (N) и выводит 
//таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

int topNum = ReadData("Введите целое число больше 0: ");

while (topNum < 1)
{
    Console.WriteLine("Число должно быть больше 0!");
    topNum = ReadData("Введите целое число боьше 0: ");
}
int i = 1; // счетчик для цикла
int cube = 0; //куб числа
int numDigitCube = 0; //количество цифр в кубе числа
string firstStr = "\u2551 Число:   \u2551"; // первая строка таблицы с границами ввиде псевдографики
string secStr = "\u2551 Куб числа:   \u2551";// вторая

while (i <= topNum)
{
    cube = (int)Math.Pow(i, 3); //вычисляем куб числа
    numDigitCube =(int)Math.Log10(cube) +1;// вычисляем кол-во цифр в кубе числа через логорифм
    firstStr = firstStr+((i).ToString()).PadRight(numDigitCube)+"\u2551";
    secStr = secStr+cube.ToString()+ "\u2551";
    i++;
}

DrawUniLine(firstStr,"\u2554","\u2566","\u2557");
Console.WriteLine(firstStr);
DrawUniLine(firstStr,"\u2560","\u256C","\u2563");
Console.WriteLine(secStr);
DrawUniLine(firstStr,"\u255A","\u2569","\u255D");

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
}