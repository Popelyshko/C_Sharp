/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int A = // ввод A
int B = // ввод B
int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine(result);

