/* Напишите программу, которая принимает на вход координаты 2 точек 
и находит расстояние между ними в 3D пространстве */

Console.WriteLine("Введите X: ");        
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int z1 = int.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2));  
Console.Write($"{s:f2}"); 