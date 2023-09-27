void Priverka (int num = 0, int num2 = 0)
{
    int firstdigit = num/100;
    int rev = num%10 * 10000 + (num/10)%10 * 1000 + (num/100)%10 * 100 + (num/1000)%10 * 10 + num/10000;
    int lastdigit = rev/100;
         
        if (firstdigit == lastdigit)
        {
        Console.WriteLine($"True");
        }
        else if (num <9999 || num >99999)
        Console.WriteLine($"Число не пятизначное");
        else 
        Console.WriteLine($"False");
}

Console.WriteLine("Enter a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Priverka(numb);

