/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа");

Console.Write("a = ");
        string inputA = Console.ReadLine();
        int a;
        while (!int.TryParse(inputA, out a))
        {
            Console.WriteLine("Некорректный ввод. Введите целое число:");
            Console.Write("a = ");
            inputA = Console.ReadLine();
        }

        Console.Write("b = ");
        string inputB = Console.ReadLine();
        int b;
        while (!int.TryParse(inputB, out b))
        {
            Console.WriteLine("Некорректный ввод. Введите целое число:");
            Console.Write("b = ");
            inputB = Console.ReadLine();
        }

        Console.Write("c = ");
        string inputC = Console.ReadLine();
        int c;
        while (!int.TryParse(inputC, out c))
        {
            Console.WriteLine("Некорректный ввод. Введите целое число:");
            Console.Write("c = ");
            inputC = Console.ReadLine();
        }

int max = Math.Max(a, Math.Max(b, c));

Console.WriteLine($"Максимальное число: {max}");

