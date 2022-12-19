Console.WriteLine ("Введите цифру дня недели ()");
int n = int.Parse(Console.ReadLine());
string s = " ";
if (n==7)
{
    s="Выходной день!";
}
else if (n==6)
{
    s="Выходной день!";
}
else if (n==5)
{
    s="Будний день!";
}
else if (n==4)
{
    s="Будний день!";
}
else if (n==3)
{
    s="Будний день!";
}
else if (n==2)
{
    s="Будний день!";
}
else if (n==1)
{
    s="Будний день!";
}
else
{
    s="не соответстует порядковому номеру дня недели!";
}
System.Console.WriteLine($"Ваше цифра {s}");
