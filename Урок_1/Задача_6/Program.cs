/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/



 Console.Write("Введите число: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Число является четным.");
            }
            else
            {
                Console.WriteLine("Число не является четным.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
             }
