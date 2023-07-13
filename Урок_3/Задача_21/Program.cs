/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


class Program
{
    static void Main(string[] args)
    {
        // Ввод координат точек A и B
        Console.WriteLine("Введите координаты точки A:");
        Console.Write("X: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Z: ");
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B:");
        Console.Write("X: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Z: ");
        double z2 = double.Parse(Console.ReadLine());

        // Вычисление расстояния между точками
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Вывод результата
        Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) равно {distance:F2}");
    }
}
