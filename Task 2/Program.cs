// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1=new Random().Next(0, 10);
double k2=new Random().Next(0, 10);
double b1=new Random().Next(0, 10);
double b2=new Random().Next(0, 10);
System.Console.WriteLine($"k1 = {k1}");
System.Console.WriteLine($"k2 = {k2}");
System.Console.WriteLine($"b1 = {b1}");
System.Console.WriteLine($"b2 = {b2}");
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine ($"Точка пересечения 2-х прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 имеет координаты: ({x}; {y})");