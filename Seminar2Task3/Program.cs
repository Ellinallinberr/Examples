//Задача №12
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число некратно первому, то программа выводит остаток от деления.

int numA = int.Parse (Console.ReadLine()??"0");
int numB = int.Parse (Console.ReadLine()??"0");
if (numB%numA == 0)
{
    Console.WriteLine ("Второе кратно первому");
}
else
{
    Console.WriteLine ("Второе число не кратно первому,остаток от деления "+ numB%numA );
}
// int f = int.Parse(Console.ReadLine()??"0");
// int s = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine((s%f==0)?true:s%f);