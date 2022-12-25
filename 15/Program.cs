// Сумма элементов массива на нечетных позициях

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 1, 10);

PrintArray(array);
Console.WriteLine();
Quantity(array);

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void Quantity(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i=(i+2))
    {
      sum=sum+array[i];
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}
