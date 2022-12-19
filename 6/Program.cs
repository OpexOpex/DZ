Console.WriteLine("Введите число: ");
int x = int.Parse (Console.ReadLine());
int index = 2;
if (x/100 > 0)
{
int number = x.ToString()[index] - '0'; //Честно, гуглил эту строку, такое же не возброняется?:)
Console.Write($"Третья цифра вашего числа: {number}");
}
else
{
    Console.Write($"Ошибка!");
}







