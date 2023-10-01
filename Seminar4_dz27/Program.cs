// Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void summa (int num)
{
    int res =0;
    while (num > 0)
    {
     res += num%10;
     num = num/10;
    }
     Console.WriteLine($"New number is {res}");
    
}

Console.WriteLine("Please enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
summa(num);