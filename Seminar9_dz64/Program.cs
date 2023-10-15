// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write($"{n} ");
    if (n > 1) ShowNumbers(n - 1);
}
Console.WriteLine("Enter N nub: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(N);