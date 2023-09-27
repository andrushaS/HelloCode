//Внутри класса Answer напишите метод DistanceBetweenPoints, который при
// нимает на вход координаты двух точек pointA и pointB в виде масси
// ва целых чисел, и возвращает расстояние между ними в 3D пространстве.




Console.WriteLine("Enter x1 point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y1 point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z1 point: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x2 point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y2 point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z2 point: ");
int y3 = Convert.ToInt32(Console.ReadLine());

int A = y1 - x1;
int B = y2 - x2;
int C = y3 - x3;

double length = Math.Round(Math.Sqrt(A * A + B * B + C * C),2);
Console.WriteLine("Расстояние = " + length);

