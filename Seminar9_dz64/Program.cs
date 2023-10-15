// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNumbers(int n)
// {
//     if (n > 1) ShowNumbers(n - 1);
//     Console.Write($"{n} ");

// }
// ShowNumbers(5);

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void che(int m, int n)
// {
//     if (m > n)
//         return;
//     if (m % 2 == 0)
//     {
//         Console.Write($"{m}, ");
//     }
//     che(m + 1, n);

// }
// che(m, n);



void ShowNumbers(int n)
{
    Console.Write($"{n} ");
    if (n > 1) ShowNumbers(n - 1);
}
Console.WriteLine("Enter the positiv nuber: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(N);