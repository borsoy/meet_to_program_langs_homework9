// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите начальное число M: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Введите начальное число M: ");
int second = int.Parse(Console.ReadLine());

void SumNumbers(int first, int second, int sum)
{
    if (first > second)
    {
        Console.WriteLine($"Сумма натуранльный чисел -> {sum}");
        return;
    }
    sum = sum + (first++);
    SumNumbers(first, second, sum);
}

SumNumbers(first, second, 0);