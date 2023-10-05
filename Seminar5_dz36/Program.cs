// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.


int [] CreateRandomArray(int min, int max, int size)
{
    int [] array = new int [size]; // временное хранилище массива. Сайз от пользователя
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumNechet(int [] array)
{
    int sum=0;
    for (int i=0; i<array.Length;i+=2)
    {       
            sum+=array[i];
    }
    Console.WriteLine($"Sum of ne chet is {sum}");
}


int min = -100;
int max = 100;
Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int [] newArray = CreateRandomArray(min,max,size);
ShowArray(newArray);
SumNechet(newArray);


