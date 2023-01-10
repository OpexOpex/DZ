//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintFromUntil(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        return;
    }
    Console.Write($"{M}, ");
    PrintFromUntil(M - 1, N);
}
PrintFromUntil(8, 1); 