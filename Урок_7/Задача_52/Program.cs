/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[3, 4]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Random random = new Random();
        int[,] array = new int[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = random.Next(10);
            }
        }

        int columns = array.GetLength(1);
        double[] averages = new double[columns];

        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            averages[j] = (double)sum / array.GetLength(0);
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{averages[j]:F1} ");
        }

        Console.ReadKey();
    }
}
