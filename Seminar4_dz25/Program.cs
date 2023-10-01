//Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

int lowTO(int firstNum, int secondNum)
{
  int res = 1;
  for(int i=1; i <= secondNum; i++){
    res = res * firstNum;
  }
    
    return res;
}

  Console.Write("Enter first number: ");
  int firstNum = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter second number: ");
  int secondNum = Convert.ToInt32(Console.ReadLine());

  int result = lowTO(firstNum, secondNum);
  Console.WriteLine($"Your number is : {result}");

