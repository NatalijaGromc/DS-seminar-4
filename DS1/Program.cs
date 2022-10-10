// Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Pow(int A, int B)
{
    int prod = 1;
    for (int i = 0; i < B; i++)
    prod = prod * A;
    return prod;
}

int A,B;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

Console.Write($"Возведение числа {A} в степени {B} = {Pow (A,B)}");