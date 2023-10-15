// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

// Без рекурсии
// void ShowNumbers(int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         Console.Write($"{i} ");
//     }
// }

// ShowNumbers(5);

// //С помощью рекурсии

// void ShowNumbers(int n)
// {
//     if (n > 1) ShowNumbers(n - 1);
//     Console.Write($"{n} ");
// }
// ShowNumbers(5);

// Факториал
// int Fuck(int n)
// {
//     if (n > 1)
//     {
//         return Fuck(n - 1) * n;
//     }
//     else
//     {
//         return 1;
//     }
// }
// int sum = Fuck(3);
// Console.WriteLine(sum);

// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

// void ShowValuesRec(int n, int m)
// {
//     if (Math.Max(m, n) != Math.Min(m, n))
//     {
//         ShowValuesRec(Math.Max(m, n), Math.Min(m, n) + 1);
//     }
//     Console.Write($"{Math.Min(m, n)} ");
// }

// Console.WriteLine("Enter n numb");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m numb");
// int m = Convert.ToInt32(Console.ReadLine());
// ShowValuesRec(n, m);
// Console.WriteLine();


// Напишите программу, которая будет принимать на вход число
// и возвращзать сумму его цифр.


// int SumDigits(int n)
// {
//     n = Math.Abs(n);
//     if (n > 10)
//     {
//         return SumDigits(n / 10) + n % 10;
//     }
//     else
//     {
//         return n;
//     }
// }

// Console.WriteLine("Enter M numb");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of digits of number {M} is {SumDigits(M)}.");