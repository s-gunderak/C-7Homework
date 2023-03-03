// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.
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
Console.Write("Введите номер ряда элемента:");
int pos_row = int.Parse(Console.ReadLine());
Console.Write("Введите номер колонки элемента:");
int pos_column = int.Parse(Console.ReadLine());
FindElement(getArray);

void FindElement(int[,] in_array)
{
    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            if (i == pos_row & j == pos_column)
            {
                Console.WriteLine($"{in_array[pos_row, pos_column]}");
            }
        }
    }
    if (pos_row > in_array.GetLength(0) || pos_column > in_array.GetLength(1))
    {
        Console.Write("По такому индексу нет элемента");
    }
}

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