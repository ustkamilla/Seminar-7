/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
1, 1 -> 1
*/

int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
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

int InputInt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


int[,] array = CreateArray(5, 5);
PrintArray(array);
int row = InputInt("Введите индекс строки элемента в двумерном массиве");
int col = InputInt("Введите индекс столбца элемента в двумерном массиве");

if (row <= array.GetLength(0) && col <= array.GetLength(1))

{
   System.Console.WriteLine($"{row}, {col} -> {array[row-1,col-1]}");
}
else
{
    System.Console.WriteLine($"{row}, {col} -> такого элемента нет в данном массиве.");
}



