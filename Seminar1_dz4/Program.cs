//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число  :");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

for(int asd =count; asd<n; asd++ )         //asd<=n если равно, то выведет вместе с N
{
   if (asd%2<1)
    Console.Write($"{asd} ");
}
