Console.WriteLine ("Введите число A");
int numberA = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите число B");
int numberB = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите число C");
int numberC = int.Parse (Console.ReadLine());

int m = numberA;

if (numberB>m)
{
    m=numberB;
}
else
{
    m=numberA;
}
if (numberC>m)
{
    m=numberC;
}
else
{
    System.Console.WriteLine($"Максимальное число: {m}");
}
System.Console.WriteLine($"Максимальное число: {m}");