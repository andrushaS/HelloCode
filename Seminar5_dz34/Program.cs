//Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

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

void Chet(int [] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
    if (array[i] %2 ==0)
        count ++;
    }
    Console.WriteLine($"Even numbers is: {count}");
}
int min = 99;
int max = 999;
Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int [] newArray = CreateRandomArray(min,max,size);
ShowArray(newArray);
Chet(newArray);
