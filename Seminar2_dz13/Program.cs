//Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.



void CutNumber (int num=0)
{
    while (num>999)
    {
        num/=10;
    }
    if (num<99)
    {
        Console.WriteLine("Третей цифры нет!");
    }
    else
    {;
        int lastdigit = num%10;
        int newnumber = lastdigit; 
        Console.WriteLine($"New number is {newnumber}");
    }
}
   
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number is {number}");
CutNumber(number);

