Console.WriteLine("Введите х1: ");
int x1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите х2: ");
int x2 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = int.Parse (Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));

System.Console.WriteLine(d);