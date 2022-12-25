//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

Console.WriteLine("Введите число k1: ");
double k1 = double.Parse (Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = double.Parse (Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse (Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = double.Parse (Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;

System.Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");