// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


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

Console.WriteLine("Введите номер строки искомого элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x > array.GetLength(0) || y > array.GetLength(1))
{
    Console.WriteLine("You Die!");
}
else
{
    object c = array.GetValue(x,y);
    Console.WriteLine($"Значение искомого элемента равно {c} ");
}