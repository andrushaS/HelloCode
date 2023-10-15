// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


int SanyaS1mple(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return SanyaS1mple(m - 1, 1);
    else return SanyaS1mple(m - 1, SanyaS1mple(m, n - 1));
}

Console.WriteLine("Enter N nub: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M nub: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {SanyaS1mple(m, n)}");