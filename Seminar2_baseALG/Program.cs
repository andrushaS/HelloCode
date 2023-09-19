// void HelloFunc(string name)
// {
//     Console.WriteLine($"Hello {name}! How are you?");
// }

// Console.WriteLine($"Hi, what is your name?");
// string fio = Console.ReadLine();
// HelloFunc(fio);


// int Quater(int num=0)
// {
    
//     int res= num*num;
//     return res;
// }

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int quat = Quater(number);
// quat += 2;
// Console.WriteLine($"Your number with quater is {quat}");

//Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// void MaxDigit(int num)
// {
//     int digit1 = num/10;
//     int digit2 = num%10;
//     if (digit1>digit2)
//         Console.WriteLine($"The biggest digit is {digit1}");
//     else
//         Console.WriteLine($"The biggest digit is {digit2}");
// }

// int number = new Random().Next(10,100);
// Console.WriteLine($"Your number is {number}");
// MaxDigit(number);

//Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого числа
// 485 -> 45
// 45 -> erorr!

// void CutNumber (int num=0)
// {
//     if (num<99 || num>999)
//     {
//         Console.WriteLine("Error");
//     }
//     else 
//     {
//         int firstdigit = num/100;
//         int lastdigit = num%10;
//         int newnumber = (firstdigit*10)+lastdigit; 
//         Console.WriteLine($"New number is {newnumber}");
//     }
// }
// Console.WriteLine("Enter number:");
// int number = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine($"Your number is {number}");
// CutNumber(number);


//Напишите программу, которая принимает нав ход 
//число и проверяет, кратно ли оно одновременно 7 и 23.

// bool Check(int number)
// {
//     if (number%7 == 0 && number%23==0)
//     return true;
//     else 
//     return false;
// }

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool flag = Check(num);

// if (flag)
//     Console.WriteLine("True!");
// else
//     Console.WriteLine("True!");

//Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

// bool AIsSquareOfB(int num1, int num2)
// {
//     if (num1==num2*num2 || num2==num1*num1)
//         return true;
//     else
//         return false;
    
// }
// Console.WriteLine("Input fisrts number:");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2=Convert.ToInt32(Console.ReadLine());

// bool isSquare = AIsSquareOfB(num1, num2);
// Console.WriteLine(isSquare);


//12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деление.

void CheckCrat(int val1, int val2)
{
    if(val2%val1==0)
    {
        Console.WriteLine("Number 2 crat to number 1");
    }
    else 
    {
        int res = val2%val1;
        Console.WriteLine($"Number is not cart, {res}");
    }
}
Console.WriteLine ("Input fisrts number");
int val1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number");
int val2=Convert.ToInt32(Console.ReadLine());
CheckCrat(val1, val2);