// Поиск элемента по позиции

System.Console.WriteLine("Введите длину массива:");
int length = ReadInt();
System.Console.WriteLine("Введите ширину массива:");
int secondLength = ReadInt();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
System.Console.WriteLine("Введите позицию элемента по длине:");
int i = ReadInt();
System.Console.WriteLine("Введите позицию элемента по ширине:");
int j = ReadInt();

if (i<=length && j<=secondLength) Console.WriteLine($"Запрошенный элемент: {array[i-1, j-1]}");
else Console.WriteLine("Такого числа в массиве нет");

int ReadInt() 
{
    return int.Parse(Console.ReadLine());
}

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(1000); 
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
