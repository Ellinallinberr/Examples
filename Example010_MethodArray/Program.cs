int[] array = {1,2,3,46,33,24,25,56};

int n = array.Length;
int find = 24;

int index = 0;

while (index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //прерви(если несколько одинаковых чисел)
    }
    index++;
}
