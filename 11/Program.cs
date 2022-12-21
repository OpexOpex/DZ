Console.WriteLine("Введите число A: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine("Введите B: ");
int y = int.Parse (Console.ReadLine());
double z = Math.Pow(x, y);
Console.Write($"число {x} в степени {y} = {z}");