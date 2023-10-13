// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

 int [,] Create2dArray (int min, int max, int row, int col)
{
    int [,] array = new int [row,col]; // создали новый двумерный массив передали количество строк и столбцов
    for (int i = 0; i<row;i++)
    {
        for (int j=0; j<col; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

// метод вывода массива на экран

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
}

void Avarage (int [,]array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum +=array[i,j];
    }
    Console.WriteLine($"Среднее арифметическое в столбце равно : {sum/array.GetLength(1)}");
    sum=0;
}
}

Console.WriteLine("Enter number of rows in array: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of col in array: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value in array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value in array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = Create2dArray(min,max,row,col);
Show2dArray(array);
Avarage(array);

