﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] arr = new double[3,4];
FillArrayRandomNumbers(arr);
PrintArray(arr);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}






