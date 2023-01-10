// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int sum = 0;
void PrintFromUntil(int M, int N)
{
    if (M > N)
    {
        return;
    }
    PrintFromUntil(M + 1, N);
    sum = sum+M;
}
PrintFromUntil(1, 5);
Console.Write(sum);