// Найти строку с наименьшей суммой элементов

System.Console.WriteLine("Введите длину массива:");
int length = ReadInt();
System.Console.WriteLine("Введите ширину массива:");
int secondLength = ReadInt();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();
GetSum(array);

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
            array[i, j] = random.Next(10); 
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

void GetSum(int[,] array)
{
    int minRow=0;
    int min=int.MaxValue;
    for (int row = 0; row < length; row++ )
    {
        int sum=0;
        for (int col = 0; col < secondLength; col++ )
        {
            sum=sum+array[row, col];
        }
        if (sum<min)
        {
            min=sum;
            minRow=row+1;
        }
    }
    System.Console.WriteLine($"Номер строки с минимальной суммой: {minRow}");
}