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
        int[,] array = new int[4, 4];
        int counter = 1;
        int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = counter;
                counter++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = counter;
                counter++;
            }
            colEnd--;

            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; i--)
                {
                    array[rowEnd, i] = counter;
                    counter++;
                }
                rowEnd--;
            }

            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    array[i, colStart] = counter;
                    counter++;
                }
                colStart++;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
