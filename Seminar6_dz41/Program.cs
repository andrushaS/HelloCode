int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];
    for (int i=0; i<size;i++)
    {
        array [i] = new Random().Next(min,max+1);
    }
    return array;
}


void ShowArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int BolsheNylya (int [] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]>0)
        {
        count++;
        }
    }
    return count;
}

Console.WriteLine("Enter min of array value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateArray(min,max,size);
ShowArray(newArray);
Console.WriteLine($"Количество чисел больше нуля : {BolsheNylya(newArray)}");