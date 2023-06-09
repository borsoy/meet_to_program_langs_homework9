﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void ShowNumber(int first, int second)
{
    if (first > second) return;
    Console.Write($"{first} ");
    ShowNumber(first + 2, second);
}

int num = 4, second = 32;
Console.Write($"M = {num}, N = {second}-> ");
ShowNumber(num, second);