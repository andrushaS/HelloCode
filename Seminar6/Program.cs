//Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] CreateArray(int min, int max, int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size;i++)
//     {
//         array [i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int [] ReverseArray(int [] array)
// {
//     int sizeArr = array.Length;
//     for (int i = 0; i<sizeArr/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[sizeArr-1-i];
//         array[sizeArr-1-i] = temp;
//     }
//     return array;
// }
// Console.WriteLine("Enter min of array value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateArray(min,max,size);
// ShowArray(newArray);
// Console.WriteLine();
// ShowArray(ReverseArray(newArray));

// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


// bool IsTriangle(int a, int b, int c)
// {
//     return a+b>c && a+c>b && b+c>a;
// }

// Console.WriteLine("Enter first part: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second part: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter third part: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (IsTriangle(a,b,c))
//     Console.WriteLine ("triangle can be alive!");
// else
//     Console.WriteLine ("POTRACHENO");

//Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное

// int BinaryNumber(int Decimal)
// {
//     int result=0;
//     int power = 0;
//     while (Decimal>0)
//     {
//         result += Decimal%2*Convert.ToInt32(Math.Pow(10, power));
//         power++;        
//         Decimal/=2;

//     }
//     return result;
// }

// Console.WriteLine("Enter the number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"10 is : {BinaryNumber(N)} ");


// : Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void PrintFibonachi(int n)
// {
//     int [] fibNum = new int [n];
//     fibNum[0]=0;
//     fibNum[1]=1;
//     for (int i=2; i<n; i++)
//     {
//         fibNum [i] = fibNum[i - 1]+fibNum[i-2];
//         Console.Write(fibNum[i] + " ");
//     }
// }
// Console.WriteLine("Enter the number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintFibonachi(N);


//Нужно найти 2 максимальных элемента произвольного массива

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

int FindMaxValue(int[] array)
{
    int max = array[0];
    int index = 0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i]>max) 
        { max = array[i];
            index=i;
        }
    }
    int [] temp = new int [array.Length-1];
    for(int j=0; j<index-1;j++)
    {
        temp [j] = array[j];
    }
    for (int k=index; k<array.Length; k++)
    {
        temp[k-1] = array [k];
    }
    array=temp;
    return max;
}
Console.WriteLine("Enter min of array value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateArray(min,max,size);
ShowArray(array1);
Console.WriteLine($"{FindMaxValue(array1)}");
Console.WriteLine($"{FindMaxValue(array1)}");