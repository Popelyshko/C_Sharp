/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два числа");

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

int max = Math.Max(a, b);
int min = Math.Min(a, b);

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");


