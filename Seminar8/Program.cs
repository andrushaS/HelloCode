// //Задайте двумерный массив. Напишите программу,которая поменяет местами
// // первую и последнюю строку массива

// int[,] Create2dArray(int min, int max, int row, int col)
// {
//     int[,] array = new int[row, col]; // создали новый двумерный массив передали количество строк и столбцов
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeRowsMatrix(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     int[,] result = new int[rows, cols];
//     Array.Copy(matrix, result, rows * cols);
//     int temp;
//     for (int j = 0; j < cols; j++)
//     {
//         temp = matrix[rows - 1, j];
//         matrix[rows - 1, j] = matrix[0, j];
//         matrix[0, j] = temp;
//     }
//     return result;
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of col in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);
// Console.WriteLine();
// int[,] newmatrix = ChangeRowsMatrix(array);
// Show2dArray(newmatrix);


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void Print2DArrayInt(int[,] matrix)
{
    Console.Write("\t");
    int tabSize = Console.CursorLeft;

    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        Console.Write($"{m}\t");
    }
    Console.WriteLine();
    Console.Write(new string('_', tabSize * (matrix.GetLength(1) + 1)));
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{i}:\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrixInt(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    matrix[0, 0] = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j - 1] + k;
        }
        if (i + 1 < matrix.GetLength(0))
            matrix[i + 1, 0] = matrix[i, matrix.GetLength(1) - 1] + k;
    }
    return matrix;
}

int[,] crossRowsAndCols(int[,] matrix)
{
    int countRow = matrix.GetLength(0);
    int countCol = matrix.GetLength(1);



    if (countCol != countRow)
    {
        int[,] buff = new int[countCol, countRow];
        for (int i = 0; i < countCol; i++)
        {
            for (int j = 0; j < countRow; j++)
            {
                buff[i, j] = matrix[j, i];
            }
        }
        return buff;
    }
    else
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = i + 1; j < countCol; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        return matrix;
    }
}

int[,] arr1 = CreateIncreasingMatrixInt(6, 6, 3); // 3 шаг отступа 
Print2DArrayInt(arr1);
Console.WriteLine();
int[,] arr2 = crossRowsAndCols(arr1);
Print2DArrayInt(arr2);