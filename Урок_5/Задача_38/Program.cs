/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


using System;

class Program {
    static void Main(string[] args) {
        double[] arr = { 3.22, 4.2, 1.15, 77.15, 65.2 };
        double max = arr[0];
        double min = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }

        double diff = max - min;
        Console.WriteLine("Max: {0}, Min: {1}, Difference: {2}", max, min, diff);
    }
}


