/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[4];
        Random rand = new Random();
        int oddSum = 0;

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rand.Next(100, 1000);
            if (i % 2 != 0) {
                oddSum += arr[i];
            }
        }

        Console.WriteLine("Generated array: [{0}]", string.Join(", ", arr));
        Console.WriteLine("Sum of elements at odd positions: {0}", oddSum);
    }
}

