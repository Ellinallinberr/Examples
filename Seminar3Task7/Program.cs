//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает
//диапазон возможных координат точек в этой
//четверти (x и y).


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return (num);
}

string QuterBorderAsk(int numQut)
{
    if (numQut == 1) return "x>0,y>0";
    if (numQut == 2) return "x>0,y<0";
    if (numQut == 3) return "x<0,y<0";
    if (numQut == 4) return "x<0,y>0";
    return "empty";
}


void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine("Координаты находятся в диапазоне следующих значений: "+ msg);
}
int quater = ReadData("Введите название четверти");
PrintResult(QuterBorderAsk(quater));