﻿Console.Write ("Input number ");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i=i+2)
{
    Console.Write($"{i}, ");
}