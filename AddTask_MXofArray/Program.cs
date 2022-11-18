//Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}

int[] SortingArrayFromMinToMax(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int max = array[0];
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j + 1] < max)
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
            else
            {
                max = array[j + 1];
            }
        }
    }
    return array;
}

int FindMexOfArray(int[] sortedFromMinToMaxarray)
{
    int elementMex = 0;
    for (int i = 0; i < sortedFromMinToMaxarray.Length; i++)
    {
        if (sortedFromMinToMaxarray[i] < 0)
        {
            continue;
        }
        if (sortedFromMinToMaxarray[i] == elementMex)
        {
            elementMex++;
        }
    }
    return elementMex;
}

int[] massive = {-5, -3, -1, -6, -2, -4, -8, -10};
int[] col = SortingArrayFromMinToMax(massive);
PrintArray(col);
System.Console.WriteLine();
System.Console.WriteLine(FindMexOfArray(col));