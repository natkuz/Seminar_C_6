//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int CountNumbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] GetArray()
{
    System.Console.WriteLine("Введите количество элементов массива:");
    int count = int.Parse(System.Console.ReadLine()!);
    int[] array = new int[count];
    System.Console.WriteLine("Введите значения элементов массива:");
    for (int i = 0; i < count; i++)
    {
        array[i] = int.Parse(System.Console.ReadLine()!);
    }
    return array;
}

int[] massive = GetArray();
System.Console.Write("Количество чисел больше 0: ");
System.Console.WriteLine(CountNumbersGreaterZero(massive));