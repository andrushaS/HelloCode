// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElements(int n, int m)
{
    if (n == m) return n;
    else return SumOfElements(Math.Min(m, n) + 1, Math.Max(m, n)) + Math.Min(m, n);
}


Console.WriteLine("Enter N nub: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M nub: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfElements(n, m));

