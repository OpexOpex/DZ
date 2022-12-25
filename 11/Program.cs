Console.WriteLine("Введите число A: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine("Введите B: ");
int y = int.Parse (Console.ReadLine());
int result = x;
for (int i = 2; i <= y; i++)
{
    result = result*x;
}
Console.Write($"число {x} в степени {y} = {result}");

