/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 }; 

int[] arr1 = new int[5]; 
Array.Copy(arr, arr1, 5); 

int[] arr2 = new int[3]; 
Array.Copy(arr, 5, arr2, 0, 3); 

Console.WriteLine("[" + string.Join(", ", arr1) + "]"); 
Console.WriteLine("[" + string.Join(", ", arr2) + "]"); 


