/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что
третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int number = int.Parse(Console.ReadLine());
int thirdDigit = (number / 100) % 10;

if (thirdDigit != 0)
{
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
