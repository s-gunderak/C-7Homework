// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество колонок массива:");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение диапазона массива:");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона массива:");
int max = int.Parse(Console.ReadLine());

int[,] getArray = GetArray(rows, columns, min, max);
PrintArray(getArray);
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