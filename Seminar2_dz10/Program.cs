//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.


void CutNumber (int num=0)
{
    if (num<99 || num>999)
    {
        Console.WriteLine("ERROR!");
    }
    else
    {;
    int firstdigit = num%100;
    int seconddigit = firstdigit/10;
    Console.WriteLine($"New number is {seconddigit}");
    }
}
   
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number is {number}");
CutNumber(number);


