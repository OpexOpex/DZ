Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse (Console.ReadLine());
int a = x/10000;
int b = (x/1000)%10;
int c = (x/10)%10;
int d = x%10;
if (a==d)
{
    if (b==c)
    {
        Console.Write($"Ваше число является палиндромом!");
    }
    else
    {
        Console.Write($"Ваше число не является палиндромом!");
    }
}
else 
{
    Console.Write($"Ваше число не является палиндромом!");
}
    