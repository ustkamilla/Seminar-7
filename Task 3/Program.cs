/*
Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        System.Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] massive = CreateArray(3, 4);
PrintArray(massive);

for (int j = 0; j < massive.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        sum += massive[i, j];
    }
    Console.Write($"{Math.Round(sum / massive.GetLength(0), 1)}; ");
}