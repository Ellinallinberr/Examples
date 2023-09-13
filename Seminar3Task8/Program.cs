//Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return (num);
}

double Distance(int x,int y)
{
    double distance = Math.Sqrt(x*x+y*y);
    return distance;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");
double res = Distance((x2-x1),(y2-y1));
PrintResult("Расстояние равно " + $"{res}");



// int x1 = int.Parse(Console.ReadLine()??"0");
// int y1 = int.Parse(Console.ReadLine()??"0");
// int x2 = int.Parse(Console.ReadLine()??"0");
// int y2 = int.Parse(Console.ReadLine()??"0");


// double findDistance(int x1,int y1,int x2,int y2){
//     return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
// }

// Console.WriteLine(findDistance(x1,y1,x2,y2));