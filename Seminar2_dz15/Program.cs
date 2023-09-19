 //Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 // и проверяет, является ли этот день выходным.



void DayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Выходной ");
  }
  
  else Console.WriteLine(" Не выходной ");
}
Console.WriteLine("Введите цифру обозначающую день недели:");

int dayNumber = Convert.ToInt32(Console.ReadLine());
DayOfTheWeek(dayNumber);