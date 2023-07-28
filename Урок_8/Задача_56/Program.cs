/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int minSum = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1}");

        Console.ReadKey();
    }
}
