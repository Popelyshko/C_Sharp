/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Введите количество чисел: ");
    int m = int.Parse(Console.ReadLine());

    int count = 0;
    for (int i = 0; i < m; i++) {
      Console.Write($"Введите число #{i+1}: ");
      int num = int.Parse(Console.ReadLine());
      if (num > 0) {
        count++;
      }
    }

    Console.WriteLine($"Количество чисел, больших нуля: {count}");
  }
}
