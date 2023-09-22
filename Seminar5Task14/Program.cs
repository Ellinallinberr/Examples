//Задача 31: Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива.

int[] GenArray(int num, int lowBotder, int highBorder)
{
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBotder, highBorder + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");

    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

(int, int) NegotivPozitivSum(int[] array)
{
    int posSum = 0;
    int negSum = 0;

    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>0)
        {
            posSum=posSum+array[i];
        }
        else
        {
            negSum+=array[i];
        }
    }
    return(posSum,negSum);
}
int[] array = GenArray(12, -9, 9);
PrintArray(array);
(int pos,int neg) sum = NegotivPozitivSum(array);

Console.WriteLine("Сумма > 0:"+sum.pos+" Сумма < 0:"+sum.neg);