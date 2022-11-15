/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[,] GetTwoDimensionalArray(int countRows, int countColumns)
{
    double[,] array = new double[countRows, countColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("Введите значение: ");
            array[i, j] = double.Parse(System.Console.ReadLine()!);
        }
    }
    return array;
}

double[,] matrix = GetTwoDimensionalArray(2, 2);

if (matrix[0, 1] != matrix[1, 1])
{
    double coordinateX = (matrix[1, 0] - matrix[0, 0]) / (matrix[0, 1] - matrix[1, 1]);
    System.Console.Write($"Координата х точки пересечения = {coordinateX}");
    System.Console.WriteLine();
    double coordinateY = matrix[0, 1] * coordinateX + matrix[0, 0];
    System.Console.Write($"Координата y точки пересечения = {coordinateY}");
}
else
{
    System.Console.WriteLine("Прямые параллельны");
}


