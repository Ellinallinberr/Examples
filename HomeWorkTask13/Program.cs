Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

if(int.Parse(num) < 99) 
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

Console.WriteLine(num[2]);

// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int num = int.Parse(Console.ReadLine() ?? "0");

// вычисляем разрядность введенного числа c помощью десятичного логарифма
double digit = Math.Log10(num);
// Конвертирую double -> int и отбрасываю дробную часть
digit = (int)digit;

// проверяем введенное число,  оно должно быть 3х значное или больше
if (digit > 1)
{
    // устанавливаем счетчик
    int count = 1;
    // объявляем переменную
    int res = num;
    while (count < digit - 1)
    {
        // отбрасываем число до 3 знаков
        res = res/10;
        count ++;
    }
    // Выводим последнюю цифру числа
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}

else
{
    // Выводим результат если введено двузначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}