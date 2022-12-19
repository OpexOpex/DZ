Console.WriteLine("Введите N: ");
int N = int.Parse (Console.ReadLine());
for (int I = 1; I<=N; I++)
{
    if (I==N){Console.Write($"{Math.Pow(I, 3)}");}
    else Console.Write($"{Math.Pow(I, 3)}, ");
}
