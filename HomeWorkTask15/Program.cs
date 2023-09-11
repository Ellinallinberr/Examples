System.Console.WriteLine("Введите число недели");
string day = Console.ReadLine()??"0";

switch (day)
{
    case "1": Console.WriteLine("нет"); break;
    case "2": Console.WriteLine("нет"); break;
    case "3": Console.WriteLine("нет"); break;
    case "4": Console.WriteLine("нет"); break;
    case "5": Console.WriteLine("нет"); break;
    case "6": Console.WriteLine("да"); break;
    case "7": Console.WriteLine("да"); break;
    default: Console.WriteLine("Неверные данные"); break;
}


// var day = new Dictionary<int, string>();
// Console.WriteLine("Введите число недели: ");
// string day = Console.ReadLine()??"0";
// {
//     [1] = "нет",
//     [2] = "нет",
//     [3] = "нет",
//     [4] = "нет",
//     [5] = "нет",
//     [6] = "да",
//     [7] = "да",
// }; 
// Console.WriteLine(day);