/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[4];
        Random rand = new Random();
        int evenCount = 0;

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rand.Next(100, 1000);
            if (arr[i] % 2 == 0) {
                evenCount++;
            }
        }

        Console.WriteLine("Generated array: [{0}]", string.Join(", ", arr));
        Console.WriteLine("Number of even elements: {0}", evenCount);
    }
}

