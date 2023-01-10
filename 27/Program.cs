// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 2;
int n = 2;

int AkkermanFunction(int m, int n)
{
    if(m == 0)
    return n + 1;
    if(n == 0)
    return AkkermanFunction(m - 1, 1);
    if(m > 0 && n > 0)
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}
Console.WriteLine($" A({m},{n}) = {AkkermanFunction(m, n)}");