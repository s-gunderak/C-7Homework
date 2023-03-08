// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] getArray = GetArray(4, 4, 0, 9);
PrintArray(getArray);
Console.Write("Среднее арифметическое каждого столбца: ");
ColumnAverage(getArray);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] new_array)
{
    for (int i = 0; i < new_array.GetLength(0); i++)
    {
        for (int j = 0; j < new_array.GetLength(1); j++)
        {
            Console.Write($"{new_array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] newArray)
{
    // int average = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        double sum = 0;
        double average = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum += newArray[j, i];
            average = sum / (newArray.GetLength(1));
        }
        Console.Write($"{average}; ");
    }
}