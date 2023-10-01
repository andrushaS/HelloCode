// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

// void SummNumb (int numb)
// {
//     int res = 0;
//     for (int i=1; i<=numb; i++)
//     {
//         res+=i;
//     }
//     Console.WriteLine($"Your sum is form 1 to {numb} is {res}");
// }
// Console.WriteLine("Please enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SummNumb(num);

// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// void NumInDec (int num)
// {
//     int count = 0;
//     while (num !=0 )
//     {
//         num /= 10;
//         count++;
//     }
//     Console.WriteLine ($"Count of number is {count}");
// }
// Console.WriteLine("Please enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// NumInDec(num);

// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// void Fact (int n)
// {
//     if (n == 1)
//     {
//         Console.WriteLine($"Your composition is 1");
//     }
//     else 
//     {
//         double res = 1;
//         for (int i=1; i<=n; i++)
//         {
//            res *= i; 
//         }
//          Console.WriteLine($"Your composition is {res}");
//     }
// }
// Console.WriteLine("Please enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Fact(num);

// Напишите программу, которая находит в последовательности
// от 1 до N все нечетные числа

// Напишите программу, которая находит 
// в последовательности от 1 до N все нечетные числа
// void OddEven(int num){
//     for(int i = 1; i<=num; i+=2){
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();
//     for(int j = 2; j<=num; j+=2){
//         Console.Write( j + " ");
//     }
// }

// Console.WriteLine("Please enter the number:");
// int num = Convert.ToInt32(Console.ReadLine());
// OddEven(num);

// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] CreateRandomArray()
// {
//     int[] array = new int [8];
//     for (int i = 0; i<8; i++)
//     {
//         array [i] = new Random(). Next(0,2);
//     }
//     return array;
// }

// void ShowArray (int [] array)
// {
//     Console.Write("[");
//     for (int i = 0; i<array.Length; i++)
//     {
//     Console.Write(array[i]+" ");
//     }
//     Console.Write("]");
// }

// ShowArray(CreateRandomArray());


















