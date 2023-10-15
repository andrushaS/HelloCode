// [1,9,3,4,5,86,0]

// 1 2 3
// 4 5 6
// 7 8 9

// метод создания рандомного двумерного массива(основываясь на чем-то) [,] <- двумерный

// int [,] Create2dArray (int min, int max, int row, int col)
// {
//     int [,] array = new int [row,col]; // создали новый двумерный массив передали количество строк и столбцов
//     for (int i = 0; i<row;i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// // метод вывода массива на экран

// void Show2dArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array [i,j]} ");
//         }
//         Console.WriteLine();
//     }
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
// int [,] array = Create2dArray(min,max,row,col);
// Show2dArray(array);

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] Create2dArray (int min, int max, int row, int col)
// {
//     int [,] array = new int [row,col]; // создали новый двумерный массив передали количество строк и столбцов
//     for (int i = 0; i<row;i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// int [,] Create2dArrayWithIndex (int row,int col)
// {
//     int [,] array = new int [row,col];
//     for (int i=0; i<row;i++)
//     {
//         for (int j=0; j<col;j++)
//         {
//             array [i,j] = i+j;
//         }
//     }
//     return array;
// }

// void Show2dArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array [i,j]} ");
//         }
//         Console.WriteLine();
//     }
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
// int [,] array = Create2dArrayWithIndex(row,col);
// Show2dArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// int [,] Create2dArray (int min, int max, int row, int col)
// {
//     int [,] array = new int [row,col]; // создали новый двумерный массив передали количество строк и столбцов
//     for (int i = 0; i<row;i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// // метод вывода массива на экран

// void Show2dArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] ChangeArray(int [,] array){
//     for(int i = 0; i<array.GetLength(0); i+=2){
//         for(int j = 0; j<array.GetLength(1); j+=2){
//             array[i,j] *= array[i,j];
//         }
//         Console.WriteLine();
//     }
//     return array;
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
// int [,] array = Create2dArray(min,max,row,col);
// Show2dArray(array);
// Console.WriteLine();
// int [,] changedArr = ChangeArray(array);
// Show2dArray(changedArr);

// Вывести на экран матрицу 4x6. Найти сумму элементов каждой строки. 
// Вывести результат в виде одномерного массива и найти его максимальный элемент


// int [,] Create2dArray (int min, int max, int row, int col)
// {
//     int [,] array = new int [row,col]; // создали новый двумерный массив передали количество строк и столбцов
//     for (int i = 0; i<row;i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// // метод вывода массива на экран

// void Show2dArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [] FindMaxes(int [,] array){
//     int [] arrayMaxes = new int [array.GetLength(0)];
//     for(int i = 0;i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             arrayMaxes[i] += array[i,j];
//         }
//     }
//     return arrayMaxes;
// }

// void ShowArrayAndMax(int [] arr){
//     for (int i = 0; i<arr.Length; i++){
//         Console.Write($"{arr[i]} ");
//     }
//     int max = arr.Max();
//     Console.Write($"Max in array is {max}");
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
// int [,] array = Create2dArray(min,max,row,col);
// Show2dArray(array);
// Console.WriteLine();
// int [] maxes = FindMaxes(array);
// ShowArrayAndMax(maxes);


// / Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] Create2dArray(int min, int max, int row, int col)
{
    int[,] array = new int[row, col]; // создали новый двумерный массив передали количество строк и столбцов
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

// метод вывода массива на экран

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    Console.WriteLine($"Sum on main diag is {sum}");
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
int[,] array = Create2dArray(min, max, row, col);
Show2dArray(array);
ShowSum(array);

