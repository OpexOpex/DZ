// Двумерный массив вещественных чисел
System.Console.WriteLine("Введите размер M");
int length = ReadInt();
System.Console.WriteLine("Введите размер N");
int secondLength = ReadInt();
double[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();

int ReadInt() 
{
    return int.Parse(Console.ReadLine());
}

double[,] GetArray (int length, int secondLength)
{
    double[,] array = new double[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = 1 + random.NextDouble()*99;
        }
    }
    return array;
}

void PrintArray (double[,] array)
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