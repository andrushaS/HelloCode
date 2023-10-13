﻿// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}


void Show2dArray (double [,] array)
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



Console.WriteLine("Enter number of rows in array :");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of col in array");
int col = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[row, col];
FillArrayRandomNumbers(numbers);
Show2dArray(numbers);
