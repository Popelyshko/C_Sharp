/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все 
чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число N: ");
        int N;
        if (int.TryParse(Console.ReadLine(), out N))
        {
            Console.Write("Четные числа от 1 до N: ");
            for (int i = 2; i <= N; i += 2)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
