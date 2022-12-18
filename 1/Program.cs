Console.WriteLine ("Введите число A");
int numberA = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите число B");
int numberB = int.Parse (Console.ReadLine());

int max = 0;
int min = 0;

if (numberA>numberB)
{
    max = numberA;
    min = numberB;
    System.Console.WriteLine($"Максимальное = {max}, минимальное = {min}");
}
else if (numberA<numberB)
{
    max = numberB;
    min = numberA;
    System.Console.WriteLine($"Максимальное = {max}, минимальное = {min}");
}
else 
{
  System.Console.WriteLine("ОШИБКА");
}
