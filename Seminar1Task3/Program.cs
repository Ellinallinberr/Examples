Console.WriteLine("Введите число:");
int numPositive = int.Parse(Console.ReadLine()??"0");
int numNegative = -1 * numPositive;

for (int i = numNegative; i < numPositive; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine($"{numPositive}.");
