// упорядочить по убыванию элементы каждой строчки массива
// каунтченджес написал на всякий случай, в интернете прочитал, что лучше с ним, чтобы не гонять много раз по изначально упорядроченной стрке

System.Console.WriteLine("Введите длину массива:");
int length = ReadInt();
System.Console.WriteLine("Введите ширину массива:");
int secondLength = ReadInt();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();
ChangePosition(array);

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

void ChangePosition(int[,] array)
{
    int temp=0;
    for (int row = 0; row < length; row++ )
    {

       for (int i = 0; i < secondLength-1; i++ )
       {
            // int countChanges=0;
            for (int col = 0; col < secondLength; col++ )
            {
                if(col<secondLength-1)
                {
                    if (array[row, col]<array[row, col+1])
                    {
                        temp = array[row, col];
                        array[row, col] = array[row, col+1];
                        array[row, col+1] = temp;
                        // countChanges++;
                    }
                }
            }
            // if(countChanges == 0)
            // {
            //     break;
            // }
       }
    }
    PrintArray(array);
}