﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число  :");
int num1 = Convert.ToInt32(Console.ReadLine());

int raznica = 1;

if (num1 % 2 < 1)
{
    Console.WriteLine ($"Число {num1} является чётным");
}
else 
{
    Console.WriteLine ($"Число {num1} является нечётным");
}

