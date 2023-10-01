// //Внутри класса Answer напишите метод DistanceBetweenPoints, который при
// // нимает на вход координаты двух точек pointA и pointB в виде масси
// // ва целых чисел, и возвращает расстояние между ними в 3D пространстве.




// Console.WriteLine("Enter x1 point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z1 point: ");
// int x3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z2 point: ");
// int y3 = Convert.ToInt32(Console.ReadLine());

// int A = y1 - x1;
// int B = y2 - x2;
// int C = y3 - x3;

// double length = Math.Round(Math.Sqrt(A * A + B * B + C * C),2);
// Console.WriteLine("Расстояние = " + length);

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
  int A = y1 - x1;
  int B = y2 - x2;
  int C = y3 - x3;
  return
  Length = Math.Round(Math.Sqrt(A * A + B * B + C * C),2);

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}