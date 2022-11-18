/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите значение b1: ");
double b1 = double.Parse(System.Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(System.Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = double.Parse(System.Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = double.Parse(System.Console.ReadLine()!);

if (k1 != k2)
{
    double coordinateX = (b2 - b1) / (k1 - k2);
    System.Console.Write($"Координата х точки пересечения = {coordinateX}");
    System.Console.WriteLine();
    double coordinateY = k1 * coordinateX + b1;
    System.Console.Write($"Координата y точки пересечения = {coordinateY}");
}
else
{
    if(b1 != b2)
    {
        System.Console.WriteLine("Прямые не имеют точки пересечения - прямые параллельны");
    }
    else
    {
        System.Console.WriteLine("Прямые имеют бесконечное число точек пересечение - прямые совпадают");   
    }   
}