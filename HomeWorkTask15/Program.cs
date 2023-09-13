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


// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int day = int.Parse(Console.ReadLine() ?? "0");

// Проверка введеного числа на день недели
if (day > 7 || day < 1)
{
    // Выводим результат в консоль
    Console.WriteLine("Число " + day + " не является днем недели, введите число от 1 до 7! ");
}

else
{   
    // Иницилизация словаря со значениями
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
{
    { 1, "Понедельник - Рабочий день" },
    { 2, "Вторник - Рабочий день" },
    { 3, "Среда - Рабочий день" },
    { 4, "Четверг - Рабочий день" },
    { 5, "Пятница - Рабочий день" },
    { 6, "Суббота - Выходной день" },
    { 7, "Воскресенье - Выходной день" },
};

    //Получим элемент по ключу == day
    Console.WriteLine(dayOfWeek[day]);
}